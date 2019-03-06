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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //at yarışı oyunu

       
        Random rastgele = new Random();

       

        private void Form3_Load(object sender, EventArgs e)
        {
            int birinciatuzaklik = pictureBox1.Left;
            int ikinciatuzaklik = pictureBox2.Left;
            int ucuncuatuzaklik = pictureBox3.Left;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciatıngenisligi = pictureBox1.Width;
            int ikinciatıngenisligi = pictureBox2.Width;
            int ucuncuatıngenisligi = pictureBox3.Width;

            int bitisuzakligi = label1.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);

            if (birinciatıngenisligi+pictureBox1.Left>=bitisuzakligi)
            {
                timer1.Enabled = false;
                label2.Text="Birinci at kazandı";
                label2.Visible = true;
            }
            if (ikinciatıngenisligi + pictureBox2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                label3.Text = "İkinci at kazandı";
                label3.Visible = true;
            }
            if (ucuncuatıngenisligi + pictureBox3.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                label4.Text = "Üçüncü at kazandı";
                label4.Visible = true;
            }

        }
    }
}
