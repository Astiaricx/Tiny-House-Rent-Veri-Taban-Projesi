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
    public partial class sifreUnutEkran: Form
    {
        public sifreUnutEkran()
        {
            InitializeComponent();
        }
        string sifre;
        SqlConnection conn = new SqlConnection("Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True");
        private void gonder_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sorgu = ("Select Sifre from tblKulanici where Mail='" + txtSifreunut.Text + "' ");
            SqlCommand cmd2 = new SqlCommand(sorgu, conn);
            sifre = cmd2.ExecuteScalar().ToString();           
            Gonder(txtSifreunut.Text, "Şifreniz="+sifre);
            MessageBox.Show("Şifreniz Mail Adresinize Gönderildi");
            conn.Close();
        }
        public void Gonder(string mail, string sifre)
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587; 
            client.Host = "smtp-relay.brevo.com";
            client.EnableSsl = false;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("8d0910001@smtp-brevo.com", "fxBEy2gNshO9cR6d");
            MailMessage mm = new MailMessage("thrental41@gmail.com", mail, "THR PAROLA", "Sifreniz = " + sifre);
            mm.IsBodyHtml = true;
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.Send(mm); // Mail yolla
        }

        private void sifreUnutEkran_Load(object sender, EventArgs e)
        {

        }
    }
}
