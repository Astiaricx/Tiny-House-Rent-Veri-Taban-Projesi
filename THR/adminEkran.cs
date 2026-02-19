using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace THR
{
    public partial class adminEkran: Form
    {
        public adminEkran(int kId)
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True");
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void adminEkran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHRdbDataSet9.RezervasyonEkran' table. You can move, or remove it, as needed.
            this.rezervasyonEkranTableAdapter.Fill(this.tHRdbDataSet9.RezervasyonEkran);
            // TODO: This line of code loads data into the 'tHRdbDataSet8.kiraciEkran3' table. You can move, or remove it, as needed.
            this.kiraciEkran3TableAdapter.Fill(this.tHRdbDataSet8.kiraciEkran3);
            // TODO: This line of code loads data into the 'tHRdbDataSet7.tblKullanici' table. You can move, or remove it, as needed.
            this.tblKullaniciTableAdapter.Fill(this.tHRdbDataSet7.tblKullanici);
            this.Controls.Add(pnlKullanici);
            this.Controls.Add(pnlIlan);
            this.Controls.Add(pnlRezervasyon);
            this.Controls.Add(pnlAnasayfa);
            AktifKullaniciSayisiGoster();
            AktifIlanSayisi();
            AktifRezervasyonSayisi();
            ToplamRez();
        }

        private void dataGVkullanici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGVkullanici_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilen = dataGVkullanici.SelectedCells[0].RowIndex;
            txtAd.Text = dataGVkullanici.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGVkullanici.Rows[secilen].Cells[2].Value.ToString();
            txtMail.Text = dataGVkullanici.Rows[secilen].Cells[4].Value.ToString();
            txtTel.Text = dataGVkullanici.Rows[secilen].Cells[3].Value.ToString();
            txtSifre.Text = dataGVkullanici.Rows[secilen].Cells[5].Value.ToString();
            cmbRol.Text= dataGVkullanici.Rows[secilen].Cells[6].Value.ToString();
            if (dataGVkullanici.Rows[secilen].Cells[7].Value.ToString()=="True")
            {
                checkBoxAktif.Checked = true;
            }
            else
                checkBoxAktif.Checked= false;
        }
        string comborol;
        Boolean aktiflik;
        private void btnEkle_Click(object sender, EventArgs e)

        {
            if (cmbRol.Text == "Ev Sahibi")
            {
                comborol = "evsahibi";
            }
            else
                comborol = "kiraci";
            if (checkBoxAktif.Checked==true)
            {
                aktiflik = true;
            }
            else
                aktiflik= false;
                conn.Open();
            SqlCommand cmd = new SqlCommand("insert into tblKullanici (Ad,Soyad,TelNo,Mail,Sifre,Rol,aktif) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", conn);
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", txtTel.Text);
            cmd.Parameters.AddWithValue("@p4", txtMail.Text);
            cmd.Parameters.AddWithValue("@p5", txtSifre.Text);
            cmd.Parameters.AddWithValue("@p6", comborol);
            cmd.Parameters.AddWithValue("@p7", aktiflik);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnKsil_Click(object sender, EventArgs e)
        {
            if (dataGVkullanici.SelectedRows.Count > 0)
            {
                int kullaniciID = Convert.ToInt32(dataGVkullanici.SelectedRows[0].Cells[0].Value);
                string connectionString = "Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM tblKullanici WHERE kullaniciId = @kullaniciID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@kullaniciID", kullaniciID);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla silindi.");                          
                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi başarısız.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek satırı seçin.");
            }
        }
        Boolean aktif;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int secilen = dataGVkullanici.SelectedCells[0].RowIndex;
            conn.Open();
            if (checkBoxAktif.Checked == true)
            {
                aktif = true;
            }
            else
                aktif = false;
            SqlCommand kullaniciGuncelle = new SqlCommand(@"UPDATE tblKullanici SET Ad = @ad, Soyad = @soyad, TelNo=@tel, Mail=@mail, Sifre=@sifre,aktif=@aktif WHERE kullaniciId = @kid", conn);
            kullaniciGuncelle.Parameters.AddWithValue("@ad", txtAd.Text);
            kullaniciGuncelle.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            kullaniciGuncelle.Parameters.AddWithValue("@tel", txtTel.Text);
            kullaniciGuncelle.Parameters.AddWithValue("@mail", txtMail.Text);
            kullaniciGuncelle.Parameters.AddWithValue("aktif", aktif);
            kullaniciGuncelle.Parameters.AddWithValue("@kid", dataGVkullanici.Rows[secilen].Cells[0].Value.ToString());
            kullaniciGuncelle.ExecuteNonQuery();
            conn.Close();
        }

        private void btnAyrinti_Click(object sender, EventArgs e)
        {
            groupBoxIlanDetay.Visible = true;
            int secilen = kiraciDgw.SelectedCells[0].RowIndex;
            lblIlanNo.Text = kiraciDgw.Rows[secilen].Cells[0].Value.ToString();
            lblBaslik.Text = kiraciDgw.Rows[secilen].Cells[1].Value.ToString();
            lblAciklama.Text = kiraciDgw.Rows[secilen].Cells[2].Value.ToString();
            lblAd.Text = kiraciDgw.Rows[secilen].Cells[5].Value.ToString();
            lblSoyad.Text = kiraciDgw.Rows[secilen].Cells[6].Value.ToString();
            puanGetir(kiraciDgw.Rows[secilen].Cells[0].Value.ToString());
            pictureGetir(kiraciDgw.Rows[secilen].Cells[0].Value.ToString());
            yorumGetir(kiraciDgw.Rows[secilen].Cells[0].Value.ToString());
        }

        public void puanGetir(string ilanID)
        {
            string connectionString = "Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True";
            string query = @"SELECT AVG(puan) AS OrtalamaPuan,COUNT(*) AS YorumSayisi FROM tblYorum WHERE ilanID = '" + ilanID + "'";

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
       

        public void yorumGetir(string ilanID)
        {

            string connectionString = "Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT * FROM YorumGetir1 WHERE ilanID ='" + ilanID + "' ";

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
            string query = "SELECT resimYolu FROM tblResim WHERE ilanID = '" + ilanID + "'";
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

        private void kullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlIlan.Visible = false;
            pnlRezervasyon.Visible = false;
            pnlAnasayfa.Visible = false;
            pnlKullanici.BringToFront();
            pnlKullanici.Visible = true;
        }

        private void ilanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlKullanici.Visible=false;
            pnlRezervasyon.Visible = false;
            pnlAnasayfa.Visible=false;
            pnlIlan.BringToFront();
            pnlIlan.Visible = true;
        }

        private void btnIlanSil_Click(object sender, EventArgs e)
        {
            if (kiraciDgw.SelectedRows.Count > 0)
            {
                int secilen = kiraciDgw.SelectedCells[0].RowIndex;
                int ilanId = Convert.ToInt32(kiraciDgw.Rows[secilen].Cells[0].Value.ToString());
                string connectionString = "Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM tblİlan WHERE ilanId = @ilanId";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ilanId", ilanId);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("İlan başarıyla silindi.");
                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi başarısız.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek satırı seçin.");
            }
        }

        private void btnYrmSil_Click(object sender, EventArgs e)
        {
            if (dataGridyorum.SelectedRows.Count > 0)
            {
                int secilen = dataGridyorum.SelectedCells[0].RowIndex;
                int yorumId = Convert.ToInt32(dataGridyorum.Rows[secilen].Cells[0].Value.ToString());
                string connectionString = "Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM tblYorum WHERE yorumId = @yorumId";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@kullaniciID", yorumId);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Yorum başarıyla silindi.");
                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi başarısız.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek satırı seçin.");
            }
        }

        private void pnlRezervasyon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRezSil_Click(object sender, EventArgs e)
        {
            if (dataGridRezervasyon.SelectedRows.Count > 0)
            {
                int secilen = dataGridRezervasyon.SelectedCells[0].RowIndex;
                int rezId = Convert.ToInt32(dataGridRezervasyon.Rows[secilen].Cells[0].Value.ToString());
                string connectionString = "Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM tblRezervasyon WHERE rezId = @rezId";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@rezId", rezId);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Rezervasyon başarıyla silindi.");
                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi başarısız.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek satırı seçin.");
            }
        }

        private void rezervasyonlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlKullanici.Visible = false;
            pnlIlan.Visible = false;
            pnlAnasayfa.Visible = false;
            pnlRezervasyon.BringToFront();
            pnlRezervasyon.Visible = true;
        }
        private void AktifKullaniciSayisiGoster()
        {
            string connectionString = "Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT COUNT(*) FROM tblKullanici WHERE aktif = 1";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    int aktifKullaniciSayisi = (int)cmd.ExecuteScalar();
                    lblAktif.Text = $"Aktif Kullanıcı Sayısı: {aktifKullaniciSayisi}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

        }
        private void AktifIlanSayisi()
        {
            string connectionString = "Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT COUNT(*) FROM tblİlan";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    int aktifIlanSayisi = (int)cmd.ExecuteScalar();
                    lblAktifIlan.Text = aktifIlanSayisi.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void AktifRezervasyonSayisi()
        {
            string connectionString = "Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT COUNT(*) FROM tblRezervasyon";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    int aktifRezSayisi = (int)cmd.ExecuteScalar();
                    lblAktifRez.Text = aktifRezSayisi.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void ToplamRez()
        {
            string connectionString = "Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT SUM(dbo.toplamFiyatHesapla(rezId)) AS ToplamFiyat FROM tblRezervasyon";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    int toplamRez = (int)cmd.ExecuteScalar();
                    lblAktifRez.Text = toplamRez.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlRezervasyon.Visible = false;
            pnlIlan.Visible = false;
            pnlKullanici.Visible = false;
            pnlAnasayfa.BringToFront();
            pnlAnasayfa.Visible = true;
        }

        private void adminEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
