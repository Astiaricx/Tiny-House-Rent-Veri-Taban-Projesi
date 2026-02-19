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

namespace THR
{
    public partial class evSahibiEkran: Form
    {
        public evSahibiEkran(int kId)
        {
            InitializeComponent();
            this.KullaniciId = kId;
        }
        private int KullaniciId;
        SqlConnection conn = new SqlConnection("Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True");
        private void çdemeBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlIlan.Visible = true;
            pnlRezervasyon.Visible = false;
            pnlIlan.BringToFront();
        }
        public void ilanGetir(int kullaniciID)
        {
            string connectionString = "Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT * FROM tblİlan WHERE kullaniciID ='" + kullaniciID + "' ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGVilan.DataSource = dt;
            }
            dataGVilan.Columns["ilanID"].Visible = false;
            dataGVilan.Columns["kullaniciID"].Visible = false;           
            dataGVilan.ReadOnly = false; ;
            dataGVilan.AllowUserToAddRows = false;
            dataGVilan.AllowUserToDeleteRows = true;
            dataGVilan.AllowUserToOrderColumns = true;
            dataGVilan.Columns["ilanBaslik"].DisplayIndex = 0;
            dataGVilan.Columns["aciklama"].DisplayIndex = 1;
            dataGVilan.Columns["il"].DisplayIndex = 2;
            dataGVilan.Columns["fiyat"].DisplayIndex = 3;
            dataGVilan.Columns["ilanBaslik"].HeaderText = "Başlık";
            dataGVilan.Columns["aciklama"].HeaderText = "Açıklama";
            dataGVilan.Columns["il"].HeaderText = "Konum";
            dataGVilan.Columns["fiyat"].HeaderText = "Fiyat";
            foreach (DataGridViewColumn col in dataGVilan.Columns)
            {
                col.Resizable = DataGridViewTriState.False;
            }
            dataGVilan.AllowUserToResizeRows = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void evSahibiEkran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHRdbDataSet6.EvSahibiRezervasyon' table. You can move, or remove it, as needed.
            this.evSahibiRezervasyonTableAdapter.Fill(this.tHRdbDataSet6.EvSahibiRezervasyon);
            ilanGetir(KullaniciId);
            orjPicture = pictureAna.Image;
            this.Controls.Add(pnlRezervasyon);
            this.Controls.Add(pnlIlan);
            pnlIlan.Visible = true;
            pnlRezervasyon.Visible = false;
            pnlIlan.BringToFront();
        }
        Image orjPicture;
        private void btnAddUpd_Click(object sender, EventArgs e)
        {
            groupBoxIlanDetay.Visible = true;
            txtAciklama.Clear();
            txtBaslik.Clear();
            txtFiyat.Clear();
            txtKonum.Clear();
            dataGridyorum.Visible = false;
            pictureAna.Image = orjPicture;
            pictureEv1.Image = orjPicture;
            pictureEv2.Image = orjPicture;
            pictureEv3.Image = orjPicture;
            label7.Visible=false;



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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            groupBoxIlanDetay.Visible = true;
            int secilen = dataGVilan.SelectedCells[0].RowIndex;
            txtBaslik.Text = dataGVilan.Rows[secilen].Cells["ilanBaslik"].Value.ToString();
            txtAciklama.Text = dataGVilan.Rows[secilen].Cells["aciklama"].Value.ToString();
            txtKonum.Text = dataGVilan.Rows[secilen].Cells[2].Value.ToString();
            txtFiyat.Text = dataGVilan.Rows[secilen].Cells[3].Value.ToString();
            dataGridyorum.Visible = true;
            label7.Visible = true;
            yorumGetir(dataGVilan.Rows[secilen].Cells["ilanID"].Value.ToString());
            pictureGetir(dataGVilan.Rows[secilen].Cells["ilanID"].Value.ToString());
            
        }

        private void pictureAna_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureAna.Image = Image.FromFile(ofd.FileName);
                pictureAna.Tag = ofd.FileName; 
            }
        }

        private void pictureEv1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureEv1.Image = Image.FromFile(ofd.FileName);
                pictureEv1.Tag = ofd.FileName; 
            }
        }

        private void pictureEv2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureEv2.Image = Image.FromFile(ofd.FileName);
                pictureEv2.Tag = ofd.FileName; 
            }
        }

        private void pictureEv3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureEv3.Image = Image.FromFile(ofd.FileName);
                pictureEv3.Tag = ofd.FileName; 
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int ilanId = -1;
            if (pictureAna.Tag == null || pictureEv1.Tag==null || pictureEv2.Tag == null || pictureEv3.Tag == null )
            {
                MessageBox.Show("Lütfen bir resim seçin.");
                return;
            }
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"insert into tblİlan (kullaniciId,il,fiyat,aciklama,ilanBaslik) values (@p1,@p2,@p3,@p4,@p5); SELECT SCOPE_IDENTITY();", conn);
            cmd.Parameters.AddWithValue("@p1", KullaniciId);
            cmd.Parameters.AddWithValue("@p2", txtKonum.Text);
            cmd.Parameters.AddWithValue("@p3", txtFiyat.Text);
            cmd.Parameters.AddWithValue("@p4", txtAciklama.Text);
            cmd.Parameters.AddWithValue("@p5", txtBaslik.Text);
            object result = cmd.ExecuteScalar();
            ilanId = Convert.ToInt32(result);
            conn.Close();
            string[] yollar = new string[4];
            yollar[0] = pictureAna.Tag?.ToString();
            yollar[1] = pictureEv1.Tag?.ToString();
            yollar[2] = pictureEv2.Tag?.ToString();
            yollar[3] = pictureEv3.Tag?.ToString();           

            using (SqlConnection baglanti = new SqlConnection("Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True"))
            {
                baglanti.Open();

                foreach (var yol in yollar)
                {
                    if (!string.IsNullOrEmpty(yol))
                    {
                        SqlCommand komut = new SqlCommand("INSERT INTO tblResim (ilanID, resimYolu) VALUES (@ilan_id, @resim_yolu)", baglanti);
                        komut.Parameters.AddWithValue("@ilan_id", ilanId);
                        komut.Parameters.AddWithValue("@resim_yolu", yol);
                        komut.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Tüm resimler veritabanına kaydedildi.");
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            ilanGetir(KullaniciId);
        }

        private void pnlRezervasyon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            pnlRezervasyon.Visible = true;
            pnlIlan.Visible = false;
            pnlRezervasyon.BringToFront();
            rezervasyonGetir(KullaniciId);
        }

        public void rezervasyonGetir(int kullaniciID)
        {
            string connectionString = "Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True";

            
            string query = @"
        SELECT *, dbo.toplamFiyatHesapla(rezId) AS ToplamFiyat FROM EvSahibiRezervasyon2 WHERE kullaniciId = @kullaniciID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kullaniciID", kullaniciID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGVrezervasyon.DataSource = dt;
                }
            }

          
            dataGVrezervasyon.Columns["kullaniciID"].Visible = false;
            dataGVrezervasyon.Columns["rezId"].Visible = false;

            
            dataGVrezervasyon.ReadOnly = true;
            dataGVrezervasyon.AllowUserToAddRows = false;
            dataGVrezervasyon.AllowUserToDeleteRows = false;
            dataGVrezervasyon.AllowUserToOrderColumns = false;

            foreach (DataGridViewColumn col in dataGVrezervasyon.Columns)
            {
                col.Resizable = DataGridViewTriState.False;
            }

            dataGVrezervasyon.AllowUserToResizeRows = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int secilen = dataGVilan.SelectedCells[0].RowIndex;
            conn.Open();
            SqlCommand ilanGuncelle = new SqlCommand(@"UPDATE tblİlan SET ilanBaslik = @baslik, aciklama = @aciklama, fiyat=@fiyat, il=@konum WHERE ilan_id = @ilan_id", conn);

            ilanGuncelle.Parameters.AddWithValue("@baslik", txtBaslik.Text);
            ilanGuncelle.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
            ilanGuncelle.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
            ilanGuncelle.Parameters.AddWithValue("@konum", txtKonum.Text);
            ilanGuncelle.Parameters.AddWithValue("@ilan_id", dataGVilan.Rows[secilen].Cells["ilanId"].Value.ToString());
            ilanGuncelle.ExecuteNonQuery();
            SqlCommand silKomut = new SqlCommand("DELETE FROM tblResim WHERE ilanID = @ilan_id", conn);
            silKomut.Parameters.AddWithValue("@ilan_id", dataGVilan.Rows[secilen].Cells["ilanID"].Value.ToString());
            silKomut.ExecuteNonQuery();
            string[] yollar = new string[4];
            yollar[0] = pictureAna.Tag?.ToString();
            yollar[1] = pictureEv1.Tag?.ToString();
            yollar[2] = pictureEv2.Tag?.ToString();
            yollar[3] = pictureEv3.Tag?.ToString();

            using (SqlConnection baglanti = new SqlConnection("Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True"))
            {
                baglanti.Open();

                foreach (var yol in yollar)
                {
                    if (!string.IsNullOrEmpty(yol))
                    {
                        SqlCommand komut = new SqlCommand("INSERT INTO tblResim (ilanID, resimYolu) VALUES (@ilan_id, @resim_yolu)", baglanti);
                        komut.Parameters.AddWithValue("@ilan_id", dataGVilan.Rows[secilen].Cells["ilanId"].Value.ToString());
                        komut.Parameters.AddWithValue("@resim_yolu", yol);
                        komut.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Tüm resimler veritabanına kaydedildi.");
            }

            conn.Close();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            if (dataGVrezervasyon.SelectedRows.Count > 0)
            {
                
                int rezId = Convert.ToInt32(dataGVrezervasyon.SelectedRows[0].Cells["rezId"].Value);

                
                string connectionString = "Data Source=ABDULLAH\\SQLEXPRESS;Initial Catalog=THRdb;Integrated Security=True;TrustServerCertificate=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM tblRezervasyon WHERE rezId = @rezId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@rezId", rezId);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Rezervasyon silindi.");
                            
                            dataGVrezervasyon.Rows.RemoveAt(dataGVrezervasyon.SelectedRows[0].Index);
                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi başarısız.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir satır seçin.");
            }
        }

        private void evSahibiEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
