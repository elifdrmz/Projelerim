using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M303SalesWinFApp_v2_11subat_
{
    public partial class Kullanici_islem : Form
    {
        public Kullanici_islem()
        {
            InitializeComponent();
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            this.Hide();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciEkle KullaniciEkle = new KullaniciEkle();
            KullaniciEkle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullaniciSil KullaniciSil = new KullaniciSil();
            KullaniciSil.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullaniciGuncelle KullaniciGuncelle = new KullaniciGuncelle();
            KullaniciGuncelle.Show();
        }
    }
}
