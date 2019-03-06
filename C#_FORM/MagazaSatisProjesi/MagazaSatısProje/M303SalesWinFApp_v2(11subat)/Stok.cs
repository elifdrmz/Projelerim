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
using System.Data.OleDb;

namespace M303SalesWinFApp_v2_11subat_
{
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }

        SqlConnection Baglanti = new SqlConnection("Data Source=PC-BILGISAYAR;Initial Catalog=M303SalesDB;Integrated Security=True");

        //datagrid e verileri ekleme
        private void Stok_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select ProductID,Name,Quantity from Products", Baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }



        //ürün adı ile ürün ID, adı ve adetini görmek
        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommand md = new SqlCommand();
            md.CommandText = "Select * from Products where Name='" + textBox1.Text + "'";
            md.Connection = Baglanti;
            md.CommandType = CommandType.Text;
            SqlDataReader dr;
            Baglanti.Open();
            dr = md.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["ProductID"].ToString();
                textBox3.Text = dr["Name"].ToString();
                textBox4.Text = dr["Quantity"].ToString();
                MessageBox.Show("Kayıt Bulundu");
                textBox2.Text = "";
                textBox3.Text="";
                textBox4.Text = "";

            }
            else
            {

                MessageBox.Show("Kayıt Bulunamadı!");
            }

            Baglanti.Close();

         
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

      
    }
}
