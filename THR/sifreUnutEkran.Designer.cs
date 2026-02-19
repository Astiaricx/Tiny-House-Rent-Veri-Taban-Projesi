namespace THR
{
    partial class sifreUnutEkran
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
            this.txtSifreunut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gonder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSifreunut
            // 
            this.txtSifreunut.Location = new System.Drawing.Point(154, 34);
            this.txtSifreunut.Name = "txtSifreunut";
            this.txtSifreunut.Size = new System.Drawing.Size(176, 22);
            this.txtSifreunut.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mail Adresiniz:";
            // 
            // gonder
            // 
            this.gonder.Location = new System.Drawing.Point(255, 62);
            this.gonder.Name = "gonder";
            this.gonder.Size = new System.Drawing.Size(75, 31);
            this.gonder.TabIndex = 2;
            this.gonder.Text = "Gönder";
            this.gonder.UseVisualStyleBackColor = true;
            this.gonder.Click += new System.EventHandler(this.gonder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(415, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // sifreUnutEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 171);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gonder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifreunut);
            this.Name = "sifreUnutEkran";
            this.Text = "sifreUnutEkran";
            this.Load += new System.EventHandler(this.sifreUnutEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifreunut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gonder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}