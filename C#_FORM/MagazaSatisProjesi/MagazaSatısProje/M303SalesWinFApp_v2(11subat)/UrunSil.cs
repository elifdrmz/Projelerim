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
    public partial class UrunSil : Form
    {
        public UrunSil()
        {
            InitializeComponent();
        }

        SqlConnection Baglanti = new SqlConnection("Data Source=PC-BILGISAYAR;Initial Catalog=M303SalesDB;Integrated Security=True");


        //datagrid e verileri ekleme

        private void UrunSil_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Name,Price from Products", Baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

  

        //datagrid ten seçtiğin herhangi bir veriyi textBox lara aktarma
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            string UrunAdi = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string UrunFiyati= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox1.Text = UrunAdi;
            textBox2.Text = UrunFiyati;
        
        }

        //silme işlemini gerçekleştirir
        private void button1_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand Urunsil = new SqlCommand("Delete from Products where  Name=@adi", Baglanti);
            Urunsil.Parameters.AddWithValue("@adi", textBox1.Text);

            Urunsil.ExecuteNonQuery();

            ListeGetir();

            Baglanti.Close();
        }

        //metot oluşturduk liste getirsin diye
        private void ListeGetir()
        {
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
