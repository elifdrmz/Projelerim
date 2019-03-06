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
    public partial class urunler_islem : Form
    {
        public urunler_islem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunEkle urunekle = new UrunEkle();
            urunekle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrunSil urunsil = new UrunSil();
            urunsil.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UrunGuncelle urunguncelle = new UrunGuncelle();
            urunguncelle.Show();
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
