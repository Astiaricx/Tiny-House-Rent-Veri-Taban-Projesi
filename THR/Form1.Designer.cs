namespace THR
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGirisYon = new System.Windows.Forms.Button();
            this.btnKayitYon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(84, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoşgeldiniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(320, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnGirisYon
            // 
            this.btnGirisYon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYon.Location = new System.Drawing.Point(66, 139);
            this.btnGirisYon.Name = "btnGirisYon";
            this.btnGirisYon.Size = new System.Drawing.Size(105, 50);
            this.btnGirisYon.TabIndex = 2;
            this.btnGirisYon.Text = "Giriş Yap";
            this.btnGirisYon.UseVisualStyleBackColor = true;
            this.btnGirisYon.Click += new System.EventHandler(this.btnGirisYon_Click);
            // 
            // btnKayitYon
            // 
            this.btnKayitYon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitYon.Location = new System.Drawing.Point(197, 139);
            this.btnKayitYon.Name = "btnKayitYon";
            this.btnKayitYon.Size = new System.Drawing.Size(105, 50);
            this.btnKayitYon.TabIndex = 3;
            this.btnKayitYon.Text = "Kayıt Ol";
            this.btnKayitYon.UseVisualStyleBackColor = true;
            this.btnKayitYon.Click += new System.EventHandler(this.btnKayitYon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 281);
            this.Controls.Add(this.btnKayitYon);
            this.Controls.Add(this.btnGirisYon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "THR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGirisYon;
        private System.Windows.Forms.Button btnKayitYon;
    }
}

