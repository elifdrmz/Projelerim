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
    public partial class KullaniciSil : Form
    {
        public KullaniciSil()
        {
            InitializeComponent();
        }


        SqlConnection Baglanti = new SqlConnection("Data Source=PC-BILGISAYAR;Initial Catalog=M303SalesDB;Integrated Security=True");


        //datagrid e verileri ekleme
        private void KullaniciSil_Load(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("Select Ad,Soyad,E_Mail,Tel,Sube from Employees", Baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
     

        //datagrid ten seçtiğin herhangi bir veriyi textBox lara aktarma

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            string Ad = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string Soyad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string E_Mail = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            string Tel = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            string Sube = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

            textBox1.Text = Ad;
            textBox2.Text = Soyad;
            textBox3.Text = E_Mail;
            textBox4.Text = Tel;
            textBox5.Text = Sube;
        }


        //silme işlemini gerçekleştirir

        private void button1_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand kayitsil = new SqlCommand("Delete from Employees where  Ad=@adi", Baglanti);
            kayitsil.Parameters.AddWithValue("@adi", textBox1.Text);
            
            kayitsil.ExecuteNonQuery();


            Baglanti.Close();


            //listeyi görüntülemek için
            ListeGetir1();


        }


        public void ListeGetir1()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Ad,Soyad,E_Mail,Tel,Sube from Employees", Baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }


        
        //cikis butonu çıkış için
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
