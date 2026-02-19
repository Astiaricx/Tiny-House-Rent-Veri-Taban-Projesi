using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Security.Policy;
namespace THR
{
    public partial class girisEkran: Form
    {
        public girisEkran()
        {
            InitializeComponent();
            
        }
        string rol;
        string aktiflik;
        public int kId;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["THR.Properties.Settings.THRdbKiraEkran"].ConnectionString);
        private void btnGiris_Click(object sender, EventArgs e)
        {                     
            //Radio buton kontrolu         
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From tblKullanici where Mail=@p1 and Sifre=@p2 ", conn);
                cmd.Parameters.AddWithValue("@p1", txtMail.Text);
                cmd.Parameters.AddWithValue("@p2", txtSifre.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                //Mail adresi ve şifre kontrolü
                if (reader.Read())
                {
                
                    reader.Close();
                    string sorgu3 = ("Select aktif from tblKullanici where Mail='" + txtMail.Text + "' ");
                    SqlCommand cmd3 = new SqlCommand(sorgu3, conn);
                    aktiflik = cmd3.ExecuteScalar().ToString();                    
                if (aktiflik == "True")
                {
                    string sorgu = ("Select rol from tblKullanici where Mail='" + txtMail.Text + "' ");
                    SqlCommand cmd2 = new SqlCommand(sorgu, conn);
                    rol = cmd2.ExecuteScalar().ToString();
                    string sorgu5 = ("Select kullaniciId from tblKullanici where Mail='" + txtMail.Text + "' ");
                    SqlCommand cmd5 = new SqlCommand(sorgu5, conn);
                    kId =Convert.ToInt32(cmd5.ExecuteScalar().ToString());
                    
                    conn.Close();
                    //rol kontrolu                  
                    switch (rol)
                    {
                        //rol kontrolune gore ekrana yonlendirme 
                        case "admin":
                            adminEkran afr = new adminEkran(kId);
                            afr.Show();
                            this.Hide();
                            break;
                        case "evsahibi":
                            evSahibiEkran efr = new evSahibiEkran(kId);
                            efr.Show();
                            this.Hide();
                            break;
                        case "kiraci":
                            kiraciEkran kfr = new kiraciEkran(kId);
                            kfr.Show();
                            this.Hide();
                            break;
                        default:
                            break;
                    }
                }
                else
                    MessageBox.Show("Üyeliğiniz Aktif Değildir Admin ile İletişime Geçiniz.(durgunabdullah66@gmail.com)");   
                conn.Close();
                }
                else 
                {
                    MessageBox.Show("Yanlış Bilgi Girdiniz Tekrar Deneyiniz...");
                conn.Close ();
                }
                                  
        }
        private void sifreUnutt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifreUnutEkran sfr = new sifreUnutEkran();
            sfr.Show();            
        }

        private void girisEkran_Load(object sender, EventArgs e)
        {

        }
    }
}
