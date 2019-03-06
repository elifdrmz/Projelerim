using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30._01._2019_2
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
         
            if (Convert.ToDouble(maskedTextBox1.Text) >= 0 && Convert.ToDouble(maskedTextBox1.Text) <= 100)
            {
                if (Convert.ToDouble(maskedTextBox2.Text) >= 0 && Convert.ToDouble(maskedTextBox2.Text) <= 100)
                {
                     double ortalama = (Convert.ToDouble(maskedTextBox1.Text) +Convert.ToDouble(maskedTextBox2.Text)) / 2;
                    string harf = "";
                    if (ortalama >= 0 && ortalama < 45)
                    {
                        harf = "KALDI";
                    }
                    else if (ortalama >= 45 && ortalama < 65)
                    {
                        harf = "D";
                    }
                    else if (ortalama >= 65 && ortalama < 70)
                    {
                        harf = "C";
                    }
                    else if (ortalama >= 70 && ortalama < 85)
                    {
                        harf = "B";
                    }
                    else if (ortalama >= 85 && ortalama <= 100)
                    {
                        harf = "A";
                    }

                    dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, maskedTextBox1.Text, maskedTextBox2.Text, ortalama, harf);
                    
                     chart1.Series["Ogrenci"].Points.Add(ortalama);

                    chart1.Series["Ogrenci"].Points[sayac].AxisLabel = textBox1.Text;

                    chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -70; //ögrenci isimleri dikey yazdırsın diye

                
                    textBox1.Clear(); textBox2.Clear(); maskedTextBox1.Clear(); maskedTextBox2.Clear();
                    sayac++;
                }
                else
                {
                    MessageBox.Show("Hatalı sayı girdiniz");
                }
            }
            else
            {
                MessageBox.Show("Hatalı sayı girdiniz");
            }
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Enabled= false;textBox2.Enabled = false;maskedTextBox1.Enabled = false; maskedTextBox2.Enabled = false;
          
        }

       
    }
}
