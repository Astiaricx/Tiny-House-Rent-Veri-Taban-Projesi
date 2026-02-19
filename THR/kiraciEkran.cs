using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THR
{
    public partial class kiraciEkran: Form
    {
        public kiraciEkran(int kId)
        {
            InitializeComponent();
            this.KullaniciId = kId;
            
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True");
       

        private int KullaniciId;
        
        private void kiraciEkran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHRdbDataSet5.RezervasyonEkran' table. You can move, or remove it, as needed.
            this.rezervasyonEkranTableAdapter.Fill(this.tHRdbDataSet5.RezervasyonEkran);
            // TODO: This line of code loads data into the 'tHRdbDataSet4.kiraciEkran3' table. You can move, or remove it, as needed.
            this.kiraciEkran3TableAdapter1.Fill(this.tHRdbDataSet4.kiraciEkran3);
            // TODO: This line of code loads data into the 'tHRdbDataSet3.kiraciEkran3' table. You can move, or remove it, as needed.
            this.kiraciEkran3TableAdapter.Fill(this.tHRdbDataSet3.kiraciEkran3);
            // TODO: This line of code loads data into the 'tHRdbDataSet2.kiraciEkran2' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'tHRdbDataSet1.tblKullanici' table. You can move, or remove it, as needed.
            this.tblKullaniciTableAdapter.Fill(this.tHRdbDataSet1.tblKullanici);
            // TODO: This line of code loads data into the 'tHRdbDataSet1.tblİlan' table. You can move, or remove it, as needed.
            this.tblİlanTableAdapter1.Fill(this.tHRdbDataSet1.tblİlan);
            // TODO: This line of code loads data into the 'tHRdbDataSet.tblİlan' table. You can move, or remove it, as needed.
            this.tblİlanTableAdapter.Fill(this.tHRdbDataSet.tblİlan);
            rezervasyonGetir(KullaniciId);
            this.Controls.Add(pnlRezervasyonlarım);
            this.Controls.Add(pnlIlan);
            this.Controls.Add(pnlAnaSayfa);
            pnlAnaSayfa.Visible = true;
            pnlRezervasyonlarım.Visible = false;
            pnlIlan.Visible = false;
            pnlAnaSayfa.BringToFront();

            /*
             PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3 };
            Label[] baslikLabels = { label15,label16,label17 };
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("sp_GetTop3IlanDetay", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            int index = 0;
            while (reader.Read() && index < 3)
            {
                string baslik = reader["ilanBaslik"].ToString();
                string aciklama = reader["aciklama"].ToString(); 
                string resimYolu = reader["resimYolu"].ToString();

                
                baslikLabels[index].Text = baslik;

                
                if (File.Exists(resimYolu))
                {
                    pictureBoxes[index].Image = Image.FromFile(resimYolu);
                    pictureBoxes[index].SizeMode = PictureBoxSizeMode.StretchImage;
                }

                index++;
            }

           

            reader.Close();

            SqlCommand cmd2 = new SqlCommand("Select Ad,Soyad,TelNo,Mail,Sifre from tblKullanici tk Where tk.kullaniciId = @a1",baglanti);
            cmd2.Parameters.AddWithValue("@a1",KullaniciId);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read()) {
             txtUyeAd.Text = reader2["Ad"].ToString();
                txtUyeSoyad.Text = reader2["Soyad"].ToString();
                mtbTelefon.Text = reader2["TelNo"].ToString();
                txtMail.Text = reader2["Mail"].ToString();
                txtSifre.Text = reader2["Sifre"].ToString();

            }
            reader2.Close();
            baglanti.Close();
             */





        }
        private void btnYenile_Click(object sender, EventArgs e)
        {
           
        }

        private void ilanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rezervasyonlarımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void kiraciDgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        
        private void btnAyrinti_Click(object sender, EventArgs e)
        {
            
            groupBoxIlanDetay.Visible = true;
            int secilen=kiraciDgw.SelectedCells[0].RowIndex;
            lblIlanNo.Text = kiraciDgw.Rows[secilen].Cells[0].Value.ToString();
            lblBaslik.Text = kiraciDgw.Rows[secilen].Cells[1].Value.ToString();
            lblAciklama.Text = kiraciDgw.Rows[secilen].Cells[2].Value.ToString();
            lblAd.Text= kiraciDgw.Rows[secilen].Cells[5].Value.ToString();
            lblSoyad.Text = kiraciDgw.Rows[secilen].Cells[6].Value.ToString();
            puanGetir(kiraciDgw.Rows[secilen].Cells[0].Value.ToString());
            pictureGetir(kiraciDgw.Rows[secilen].Cells[0].Value.ToString());
            yorumGetir(kiraciDgw.Rows[secilen].Cells[0].Value.ToString());
            
        }
        public void puanGetir(string ilanID)
        {
            string connectionString = "Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True";
            string query = @"SELECT AVG(puan) AS OrtalamaPuan,COUNT(*) AS YorumSayisi FROM tblYorum WHERE ilanID = '"+ilanID+"'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        object ortResult = reader["OrtalamaPuan"];
                        object countResult = reader["YorumSayisi"];

                        if (ortResult != DBNull.Value && ortResult != null)
                        {
                            double ortalama = Convert.ToDouble(ortResult);
                            lblPuan.Text = ortalama.ToString("0.00");
                        }
                        else
                        {
                            lblPuan.Text = "Puan yok";
                        }

                        if (countResult != DBNull.Value && countResult != null)
                        {
                            int sayi = Convert.ToInt32(countResult);
                            lblYorumSayisi.Text = sayi.ToString();
                        }
                        else
                        {
                            lblYorumSayisi.Text = "0";
                        }
                    }
                }
            }
        }

        public void rezervasyonGetir(int kullaniciID)
        {
            string connectionString = "Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT * FROM RezervasyonEkran WHERE kullaniciID ='" + kullaniciID + "' ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridRezer.DataSource = dt;
            }
            dataGridRezer.Columns["ilanID"].Visible = false;
            dataGridRezer.Columns["kullaniciID"].Visible = false;
            dataGridRezer.Columns["odemeID"].Visible = false;
            dataGridRezer.Columns["rezID"].Visible = false;      
            dataGridRezer.ReadOnly = true; ;
            dataGridRezer.AllowUserToAddRows = false;
            dataGridRezer.AllowUserToDeleteRows = false;
            dataGridRezer.AllowUserToOrderColumns = false;
            foreach (DataGridViewColumn col in dataGridRezer.Columns)
            {
                col.Resizable = DataGridViewTriState.False;
            }
            dataGridRezer.AllowUserToResizeRows = false;
        }
        
        public void yorumGetir(string ilanID)
        {

            string connectionString = "Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT * FROM YorumGetir1 WHERE ilanID ='"+ilanID+"' ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridyorum.DataSource = dt;
            }
            dataGridyorum.Columns["ilanId"].Visible = false;
            dataGridyorum.Columns["Yorum"].Width = 400;
            dataGridyorum.ReadOnly = true; ;
            dataGridyorum.AllowUserToAddRows = false;
            dataGridyorum.AllowUserToDeleteRows = false;
            dataGridyorum.AllowUserToOrderColumns = false;
            foreach (DataGridViewColumn col in dataGridyorum.Columns)
            {
                col.Resizable = DataGridViewTriState.False;
            }
            dataGridyorum.AllowUserToResizeRows = false;
        }
        public void pictureGetir(string ilanID)
        {
            string query = "SELECT resimYolu FROM tblResim WHERE ilanID = '"+ilanID+"'";
            using (SqlConnection conn = new SqlConnection("Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                int index = 0;

                PictureBox[] pictureBoxes = new PictureBox[] { pictureAna, pictureEv1, pictureEv2, pictureEv3 };

                while (reader.Read() && index < pictureBoxes.Length)
                {
                    string resimYolu = reader["resimYolu"].ToString();

                    if (System.IO.File.Exists(resimYolu))
                    {
                        pictureBoxes[index].Image = Image.FromFile(resimYolu);
                        pictureBoxes[index].SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                    index++;
                }

                reader.Close();
            }
        }
        private void lblSoyad_Click(object sender, EventArgs e)
        {

        }

        private void pictureAna_Click(object sender, EventArgs e)
        {
            if (pictureAna.Dock == DockStyle.None)
                pictureAna.Dock = DockStyle.Fill;
            else pictureAna.Dock = DockStyle.None;
            pictureAna.BringToFront();
        }

        private void pictureEv1_Click(object sender, EventArgs e)
        {
            if (pictureEv1.Dock == DockStyle.None)
                pictureEv1.Dock = DockStyle.Fill;
            else pictureEv1.Dock = DockStyle.None;
            pictureEv1.BringToFront();
        }

        private void pictureEv2_Click(object sender, EventArgs e)
        {
            if (pictureEv2.Dock == DockStyle.None)
                pictureEv2.Dock = DockStyle.Fill;
            else pictureEv2.Dock = DockStyle.None;
            pictureEv2.BringToFront();
        }

        private void pictureEv3_Click(object sender, EventArgs e)
        {
            if (pictureEv3.Dock == DockStyle.None)
                pictureEv3.Dock = DockStyle.Fill;
            else pictureEv3.Dock = DockStyle.None;
            pictureEv3.BringToFront();

        }

        private void dataGridyorum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridyorum_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridyorum.SelectedCells[0].RowIndex;
            MessageBox.Show(dataGridyorum.Rows[secilen].Cells[2].Value.ToString());
        }

        private void btnRez_Click(object sender, EventArgs e)
        {
            girisEkran gkr = new girisEkran();
            string odemeTur = comboBoxOdeme.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(odemeTur))
            {
                MessageBox.Show("Lütfen bir ödeme türü seçin.");
                return;
            }

            DateTime baslangicTarihi = dateTimeBas.Value.Date;
            DateTime bitisTarihi = dateTimeBit.Value.Date;

            string connectionString = "Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string insertOdemeQuery = @"INSERT INTO tblOdeme (odemeTur, odemeDurum) VALUES (@odemeTur, @odemeDurum); SELECT CAST(scope_identity() AS int);";

                SqlCommand cmdOdeme = new SqlCommand(insertOdemeQuery, conn);
                cmdOdeme.Parameters.AddWithValue("@odemeTur", odemeTur);
                cmdOdeme.Parameters.AddWithValue("@odemeDurum", true);

                int odemeId = (int)cmdOdeme.ExecuteScalar();

                string insertRezervasyonQuery = @" INSERT INTO tblRezervasyon (basTarih, bitTarih, odemeId,ilanId,kullaniciId) VALUES (@basTarih, @bitTarih, @odemeId,@ilanId,@kullaniciId);";

                SqlCommand cmdRezervasyon = new SqlCommand(insertRezervasyonQuery, conn);
                cmdRezervasyon.Parameters.AddWithValue("@basTarih", baslangicTarihi);
                cmdRezervasyon.Parameters.AddWithValue("@bitTarih", bitisTarihi);
                cmdRezervasyon.Parameters.AddWithValue("@odemeId", odemeId);
                cmdRezervasyon.Parameters.AddWithValue("@kullaniciId", KullaniciId);
                cmdRezervasyon.Parameters.AddWithValue("@ilanId", Convert.ToInt32(lblIlanNo.Text));

                cmdRezervasyon.ExecuteNonQuery();
                

                MessageBox.Show("Rezervasyon başarıyla oluşturuldu.");
            }
        }

        private void lblAd_Click(object sender, EventArgs e)
        {

        }

        private void pnlRezervasyonlarım_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ilanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pnlIlan.Visible = true;
            pnlRezervasyonlarım.Visible = false;
            pnlAnaSayfa.Visible = false;
            pnlIlan.BringToFront();
        }

        private void rezervasyonlarımToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlRezervasyonlarım.Visible = true;                     
            pnlIlan.Visible = false;
            pnlAnaSayfa.Visible=false;
            pnlRezervasyonlarım.BringToFront();
            rezervasyonGetir(KullaniciId);

        }

        private void anasayfaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlAnaSayfa.Visible = true;
            pnlRezervasyonlarım.Visible = false;
            pnlIlan.Visible = false;
            pnlAnaSayfa.BringToFront();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd= new SqlCommand("Delete from tblRezervasyon where rezId=@p1",baglanti);
            int secilen = dataGridRezer.SelectedCells[0].RowIndex;
            cmd.Parameters.AddWithValue("@p1", dataGridRezer.Rows[secilen].Cells[0].Value.ToString());
            cmd.ExecuteNonQuery();           
            baglanti.Close();
        }

        private void btnYorum_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into tblYorum (ilanId,kullaniciId,yorum,puan) values (@p1,@p2,@p3,@p4)", baglanti);
            int secilen = dataGridRezer.SelectedCells[0].RowIndex;
            cmd.Parameters.AddWithValue("@p1", dataGridRezer.Rows[secilen].Cells[1].Value.ToString());
            cmd.Parameters.AddWithValue("@p2", KullaniciId);
            cmd.Parameters.AddWithValue("@p3", txtYorum.Text);
            cmd.Parameters.AddWithValue("@p4", txtPuan.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yorumunuz Başarılı Bir Şekilde Yapılmıştır.");
        }

        private void txtYorum_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutGuncelle = new SqlCommand("Update tblKullanici Set Ad = @a1, Soyad = @a2, TelNo = @a3, Mail = @a4 , Sifre = @a7 Where kullaniciId = @a5", baglanti);
            komutGuncelle.Parameters.AddWithValue("@a1", txtUyeAd.Text);
            komutGuncelle.Parameters.AddWithValue("@a2", txtUyeSoyad.Text);
            komutGuncelle.Parameters.AddWithValue("@a3", mtbTelefon.Text);
            komutGuncelle.Parameters.AddWithValue("@a4", txtMail.Text);
            komutGuncelle.Parameters.AddWithValue("@a5", KullaniciId);
            komutGuncelle.Parameters.AddWithValue("@a7", txtSifre.Text);
            komutGuncelle.ExecuteNonQuery();
            MessageBox.Show("Üyelik Bilgileriniz Güncellendi");


            baglanti.Close();
        }

        private void kiraciEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
