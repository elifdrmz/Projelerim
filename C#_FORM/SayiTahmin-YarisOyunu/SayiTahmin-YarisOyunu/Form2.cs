using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30._01._2019
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

      
        private void label3_Click(object sender, EventArgs e)
        {
            int hak = 5;
            Random tahmin = new Random();
            int tahminsayi = tahmin.Next(0, 50);
            if (hak==0)
            {
                label3.Text = "Hakkınız bitti.";

            }
            if (Convert.ToInt32(textBox1.Text)> tahminsayi)
            {
                label3.Text = "Daha küçük sayı giriniz.";
                hak--;
                label8.Text = hak.ToString();
            }
            else
            {
                label3.Text = "Daha büyük sayı giriniz.";
                hak--;
                label8.Text = hak.ToString();
            }
            

            //eksik kaldı devam et???????????????????????????????
        }
    }
}
