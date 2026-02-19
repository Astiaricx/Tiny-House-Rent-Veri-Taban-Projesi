using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THR
{
    public partial class kayitEkran: Form
    {
        public kayitEkran()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True");
        string adminmail;
        string comborol;
        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (cmbRol.Text == "Ev Sahibi")
            {
                comborol = "evsahibi";
            }
            else
                comborol = "kiraci";

            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into tblKullanici (Ad,Soyad,TelNo,Mail,Sifre,Rol,aktif) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)",conn);
            cmd.Parameters.AddWithValue("@p1",txtAd.Text);
            cmd.Parameters.AddWithValue("@p2",txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3",txtTel.Text);
            cmd.Parameters.AddWithValue("@p4", txtMail.Text);
            cmd.Parameters.AddWithValue("@p5", txtSifre.Text);
            cmd.Parameters.AddWithValue("@p6", comborol);
            cmd.Parameters.AddWithValue("@p7",true);
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("select Mail from tblKullanici where rol='admin'", conn);
            adminmail = cmd2.ExecuteScalar().ToString();
            
            Gonder(adminmail);
            conn.Close();                                                
            MessageBox.Show("Kayıt İşlemi Başarılı, Giriş yapabilirsiniz.");
            
        }

        public void Gonder(string mail)
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587; 
            client.Host = "smtp-relay.brevo.com"; 
            client.EnableSsl = false; 
            client.Timeout = 10000; 
            client.DeliveryMethod = SmtpDeliveryMethod.Network; 
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("8d0910001@smtp-brevo.com", "fxBEy2gNshO9cR6d"); 
            MailMessage mm = new MailMessage("thrental41@gmail.com", mail, "THR ONAY", "Yeni Kullanıcı Kayıdı Mevcut."); 
            mm.IsBodyHtml = true; 
            mm.BodyEncoding = UTF8Encoding.UTF8; 
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure; 
            client.Send(mm);
        }

        private void kayitEkran_Load(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
