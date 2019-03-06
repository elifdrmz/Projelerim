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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        SqlConnection Baglanti = new SqlConnection("Data Source=PC-BILGISAYAR;Initial Catalog=M303SalesDB;Integrated Security=True");

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Name,Price from Products", Baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }


        //ürünleri veri tabanına ekleme
        private void button1_Click(object sender, EventArgs e)
        {
            Baglanti.Open();

            //urun adini ve fiyatini Sales tablosuna aktarma
            SqlCommand urunekle = new SqlCommand("insert into Products(Name,Price) values(@p1,@p2)", Baglanti);

            if (!(textBox2.Text == ""&& textBox2.Text == ""))
            {
                urunekle.Parameters.AddWithValue("@p1", textBox1.Text);
                urunekle.Parameters.AddWithValue("@p2", textBox2.Text);
                urunekle.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Hatali");
            }

            //listeyi getirir
            ListeGetir();

            //texbox ları temizle
            textBox1.Clear();
            textBox2.Clear();

            Baglanti.Close();
        }


        private void ListeGetir()
        {
            //dataGridView tablosunda görmek için

            SqlDataAdapter da = new SqlDataAdapter("Select Name,Price from Products", Baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       
    }
}
