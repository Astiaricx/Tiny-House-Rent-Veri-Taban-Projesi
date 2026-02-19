using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THR
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYon_Click(object sender, EventArgs e)
        {
            girisEkran fr=new girisEkran();
            fr.Show();
            this.Hide();
        }

        private void btnKayitYon_Click(object sender, EventArgs e)
        {
            kayitEkran fr = new kayitEkran();
            fr.Show();
            this.Hide();
        }
    }
}
