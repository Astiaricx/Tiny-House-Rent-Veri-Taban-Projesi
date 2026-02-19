namespace THR
{
    partial class evSahibiEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(evSahibiEkran));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlIlan = new System.Windows.Forms.Panel();
            this.pnlRezervasyon = new System.Windows.Forms.Panel();
            this.btnRed = new System.Windows.Forms.Button();
            this.dataGVrezervasyon = new System.Windows.Forms.DataGridView();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBoxIlanDetay = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtKonum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridyorum = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureAna = new System.Windows.Forms.PictureBox();
            this.pictureEv1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureEv3 = new System.Windows.Forms.PictureBox();
            this.pictureEv2 = new System.Windows.Forms.PictureBox();
            this.btnDell = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGVilan = new System.Windows.Forms.DataGridView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tHRdbDataSet6 = new THR.THRdbDataSet6();
            this.evSahibiRezervasyonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evSahibiRezervasyonTableAdapter = new THR.THRdbDataSet6TableAdapters.EvSahibiRezervasyonTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.pnlIlan.SuspendLayout();
            this.pnlRezervasyon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVrezervasyon)).BeginInit();
            this.groupBoxIlanDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridyorum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVilan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHRdbDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evSahibiRezervasyonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1902, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 24);
            this.toolStripMenuItem1.Text = "İlan Yönetimi";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(14, 24);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(14, 24);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(14, 24);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(122, 24);
            this.toolStripMenuItem5.Text = "Rezervasyonlar";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // pnlIlan
            // 
            this.pnlIlan.Controls.Add(this.pnlRezervasyon);
            this.pnlIlan.Controls.Add(this.btnYenile);
            this.pnlIlan.Controls.Add(this.btnUpdate);
            this.pnlIlan.Controls.Add(this.groupBoxIlanDetay);
            this.pnlIlan.Controls.Add(this.btnDell);
            this.pnlIlan.Controls.Add(this.btnAdd);
            this.pnlIlan.Controls.Add(this.dataGVilan);
            this.pnlIlan.Location = new System.Drawing.Point(12, 39);
            this.pnlIlan.Name = "pnlIlan";
            this.pnlIlan.Size = new System.Drawing.Size(1878, 982);
            this.pnlIlan.TabIndex = 1;
            // 
            // pnlRezervasyon
            // 
            this.pnlRezervasyon.Controls.Add(this.btnRed);
            this.pnlRezervasyon.Controls.Add(this.dataGVrezervasyon);
            this.pnlRezervasyon.Location = new System.Drawing.Point(12, 39);
            this.pnlRezervasyon.Name = "pnlRezervasyon";
            this.pnlRezervasyon.Size = new System.Drawing.Size(1878, 982);
            this.pnlRezervasyon.TabIndex = 11;
            this.pnlRezervasyon.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRezervasyon_Paint);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(888, 25);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(132, 61);
            this.btnRed.TabIndex = 1;
            this.btnRed.Text = "Rezervasyon Reddet";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // dataGVrezervasyon
            // 
            this.dataGVrezervasyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVrezervasyon.Location = new System.Drawing.Point(17, 25);
            this.dataGVrezervasyon.Name = "dataGVrezervasyon";
            this.dataGVrezervasyon.RowHeadersWidth = 51;
            this.dataGVrezervasyon.RowTemplate.Height = 24;
            this.dataGVrezervasyon.Size = new System.Drawing.Size(865, 611);
            this.dataGVrezervasyon.TabIndex = 0;
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(646, 133);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(116, 34);
            this.btnYenile.TabIndex = 10;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(646, 53);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 34);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBoxIlanDetay
            // 
            this.groupBoxIlanDetay.Controls.Add(this.btnGuncelle);
            this.groupBoxIlanDetay.Controls.Add(this.btnEkle);
            this.groupBoxIlanDetay.Controls.Add(this.txtKonum);
            this.groupBoxIlanDetay.Controls.Add(this.label3);
            this.groupBoxIlanDetay.Controls.Add(this.txtFiyat);
            this.groupBoxIlanDetay.Controls.Add(this.label5);
            this.groupBoxIlanDetay.Controls.Add(this.txtAciklama);
            this.groupBoxIlanDetay.Controls.Add(this.txtBaslik);
            this.groupBoxIlanDetay.Controls.Add(this.label7);
            this.groupBoxIlanDetay.Controls.Add(this.dataGridyorum);
            this.groupBoxIlanDetay.Controls.Add(this.label4);
            this.groupBoxIlanDetay.Controls.Add(this.label2);
            this.groupBoxIlanDetay.Controls.Add(this.pictureAna);
            this.groupBoxIlanDetay.Controls.Add(this.pictureEv1);
            this.groupBoxIlanDetay.Controls.Add(this.label1);
            this.groupBoxIlanDetay.Controls.Add(this.pictureEv3);
            this.groupBoxIlanDetay.Controls.Add(this.pictureEv2);
            this.groupBoxIlanDetay.Location = new System.Drawing.Point(771, 3);
            this.groupBoxIlanDetay.Name = "groupBoxIlanDetay";
            this.groupBoxIlanDetay.Size = new System.Drawing.Size(1085, 967);
            this.groupBoxIlanDetay.TabIndex = 8;
            this.groupBoxIlanDetay.TabStop = false;
            this.groupBoxIlanDetay.Visible = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(562, 232);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(107, 30);
            this.btnGuncelle.TabIndex = 35;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(449, 232);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(107, 30);
            this.btnEkle.TabIndex = 34;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtKonum
            // 
            this.txtKonum.Location = new System.Drawing.Point(449, 134);
            this.txtKonum.Name = "txtKonum";
            this.txtKonum.Size = new System.Drawing.Size(130, 22);
            this.txtKonum.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(347, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Konum:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(449, 171);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(130, 22);
            this.txtFiyat.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(347, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fiyat:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(447, 96);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(285, 22);
            this.txtAciklama.TabIndex = 29;
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(447, 61);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(285, 22);
            this.txtBaslik.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Yorumu Ayrıntılı Görmek İçin Üstüne Çift Tıklayınız.";
            // 
            // dataGridyorum
            // 
            this.dataGridyorum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridyorum.Location = new System.Drawing.Point(36, 475);
            this.dataGridyorum.Name = "dataGridyorum";
            this.dataGridyorum.RowHeadersWidth = 51;
            this.dataGridyorum.RowTemplate.Height = 24;
            this.dataGridyorum.Size = new System.Drawing.Size(987, 273);
            this.dataGridyorum.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(345, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Açıklama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(345, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Başlık:";
            // 
            // pictureAna
            // 
            this.pictureAna.Image = ((System.Drawing.Image)(resources.GetObject("pictureAna.Image")));
            this.pictureAna.Location = new System.Drawing.Point(17, 21);
            this.pictureAna.Name = "pictureAna";
            this.pictureAna.Size = new System.Drawing.Size(300, 300);
            this.pictureAna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAna.TabIndex = 1;
            this.pictureAna.TabStop = false;
            this.pictureAna.Click += new System.EventHandler(this.pictureAna_Click);
            // 
            // pictureEv1
            // 
            this.pictureEv1.Location = new System.Drawing.Point(17, 337);
            this.pictureEv1.Name = "pictureEv1";
            this.pictureEv1.Size = new System.Drawing.Size(75, 75);
            this.pictureEv1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEv1.TabIndex = 2;
            this.pictureEv1.TabStop = false;
            this.pictureEv1.Click += new System.EventHandler(this.pictureEv1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(345, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "İlan No:";
            // 
            // pictureEv3
            // 
            this.pictureEv3.Location = new System.Drawing.Point(242, 337);
            this.pictureEv3.Name = "pictureEv3";
            this.pictureEv3.Size = new System.Drawing.Size(75, 75);
            this.pictureEv3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEv3.TabIndex = 4;
            this.pictureEv3.TabStop = false;
            this.pictureEv3.Click += new System.EventHandler(this.pictureEv3_Click);
            // 
            // pictureEv2
            // 
            this.pictureEv2.Location = new System.Drawing.Point(129, 337);
            this.pictureEv2.Name = "pictureEv2";
            this.pictureEv2.Size = new System.Drawing.Size(75, 75);
            this.pictureEv2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEv2.TabIndex = 3;
            this.pictureEv2.TabStop = false;
            this.pictureEv2.Click += new System.EventHandler(this.pictureEv2_Click);
            // 
            // btnDell
            // 
            this.btnDell.Location = new System.Drawing.Point(646, 93);
            this.btnDell.Name = "btnDell";
            this.btnDell.Size = new System.Drawing.Size(116, 34);
            this.btnDell.TabIndex = 2;
            this.btnDell.Text = "Sil";
            this.btnDell.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(646, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddUpd_Click);
            // 
            // dataGVilan
            // 
            this.dataGVilan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVilan.Location = new System.Drawing.Point(3, 3);
            this.dataGVilan.Name = "dataGVilan";
            this.dataGVilan.RowHeadersWidth = 51;
            this.dataGVilan.RowTemplate.Height = 24;
            this.dataGVilan.Size = new System.Drawing.Size(637, 976);
            this.dataGVilan.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tHRdbDataSet6
            // 
            this.tHRdbDataSet6.DataSetName = "THRdbDataSet6";
            this.tHRdbDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evSahibiRezervasyonBindingSource
            // 
            this.evSahibiRezervasyonBindingSource.DataMember = "EvSahibiRezervasyon";
            this.evSahibiRezervasyonBindingSource.DataSource = this.tHRdbDataSet6;
            // 
            // evSahibiRezervasyonTableAdapter
            // 
            this.evSahibiRezervasyonTableAdapter.ClearBeforeFill = true;
            // 
            // evSahibiEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pnlIlan);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "evSahibiEkran";
            this.Text = "evSahibiEkran";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.evSahibiEkran_FormClosed);
            this.Load += new System.EventHandler(this.evSahibiEkran_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlIlan.ResumeLayout(false);
            this.pnlRezervasyon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVrezervasyon)).EndInit();
            this.groupBoxIlanDetay.ResumeLayout(false);
            this.groupBoxIlanDetay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridyorum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVilan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHRdbDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evSahibiRezervasyonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel pnlIlan;
        private System.Windows.Forms.DataGridView dataGVilan;
        private System.Windows.Forms.Button btnDell;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBoxIlanDetay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridyorum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureAna;
        private System.Windows.Forms.PictureBox pictureEv1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureEv3;
        private System.Windows.Forms.PictureBox pictureEv2;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label5;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox txtKonum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Panel pnlRezervasyon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.DataGridView dataGVrezervasyon;
        private THRdbDataSet6 tHRdbDataSet6;
        private System.Windows.Forms.BindingSource evSahibiRezervasyonBindingSource;
        private THRdbDataSet6TableAdapters.EvSahibiRezervasyonTableAdapter evSahibiRezervasyonTableAdapter;
        private System.Windows.Forms.Button btnRed;
    }
}