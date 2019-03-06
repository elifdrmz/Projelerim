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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string kadi = "elif";
        string password = "123";

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
            Random r = new Random();
            int sayi = r.Next(1000000, 10000000);

            label3.Text = Convert.ToString(sayi);
            label3.Enabled = true;

            if (textBox3.Text.Length > 7)
            {
                if (textBox3.Text == label3.Text)
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    MessageBox.Show("hatali");
                }
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == kadi && textBox2.Text == password && textBox3.Text == label3.Text)
            {
                MessageBox.Show("giriş başarılı");
                this.Hide();
                Form2 oyunform = new Form2();
                oyunform.Show();
            }
            else if (!(textBox1.Text == kadi || textBox2.Text == password))
            {
                MessageBox.Show("kullanici adi veya şifre hatali");
            }
            else
            {
                MessageBox.Show("giriş hatalı");
            }

        }

       
        
    }
}
