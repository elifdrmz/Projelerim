using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace M303SalesWinFApp_v2_11subat_
{
    public partial class KayitEkrani : Form
    {
        public KayitEkrani()
        {
            InitializeComponent();
        }

        //kullanicilar
        private void kullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kullanici_islem kullanici_islem = new Kullanici_islem();
            kullanici_islem.Show();

        }

    
        //ürünler
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urunler_islem urunler_islem = new urunler_islem();
            urunler_islem.Show();
        }

        //satış işlemi
        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Satis satis = new Satis();
            satis.Show();
        }

        //stok görüntülemek
        private void stokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stok stok = new Stok();
            stok.Show();
        }






        //cikis islemi
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

      
    }
}
