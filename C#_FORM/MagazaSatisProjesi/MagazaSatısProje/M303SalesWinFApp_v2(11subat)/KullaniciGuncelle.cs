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
    public partial class KullaniciGuncelle : Form
    {
        public KullaniciGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection Baglanti = new SqlConnection("Data Source=PC-BILGISAYAR;Initial Catalog=M303SalesDB;Integrated Security=True");

        //listele butonuna basıp dataGrid e veri aktarma
        private void KullaniciGuncelle_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Ad,Soyad,E_Mail,Tel,Sube from Employees", Baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
  

        //dataGrid deki herhangi bir veriyi tıkladığında o satırdaki veriyi hafızaya alsın

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            string Ad = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string Soyad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string E_Mail = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            string Tel = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            string Sube = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

            //Personel detaydaki textBox lara aktarmak
            textBox1.Text = Ad;
            textBox2.Text = Soyad;
            textBox3.Text = E_Mail;
            maskedTextBox1.Text = Tel;
            comboBox2.Text = Sube;
   
        }

        //tabPage2 ye geçmek için 

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        //güncellemek için

        private void button4_Click(object sender, EventArgs e)
        {

            Baglanti.Open();

            SqlCommand kayitguncelle = new SqlCommand("update Employees set Ad=@p1,Soyad=@p2,E_Mail=@p3,Tel=@p4,UserName=@p5,UserPass=@p6,Kul_Tipi=@p7,Dogum_Tarihi=@p8,Cinsiyet=@p9,Sube=@p10  where Ad=@p1", Baglanti);

           kayitguncelle.Parameters.AddWithValue("@p1", textBox1.Text);
           kayitguncelle.Parameters.AddWithValue("@p2", textBox2.Text);
           kayitguncelle.Parameters.AddWithValue("@p3", textBox3.Text);
           kayitguncelle.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
           kayitguncelle.Parameters.AddWithValue("@p5", textBox4.Text);
           kayitguncelle.Parameters.AddWithValue("@p6", textBox6.Text);
           kayitguncelle.Parameters.AddWithValue("@p7", comboBox1.Text);
           kayitguncelle.Parameters.AddWithValue("@p8", dateTimePicker1.Value);
           kayitguncelle.Parameters.AddWithValue("@p9", radioButton1.Text);
           kayitguncelle.Parameters.AddWithValue("@p10", comboBox2.Text);

           kayitguncelle.ExecuteNonQuery();

    


            Baglanti.Close();

            //listeyi görüntülemek için
            ListeGetir();

        }


        public void ListeGetir()
        {
            Baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Ad,Soyad,E_Mail,Tel,Sube from Employees", Baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


            tabControl1.SelectedTab = tabPage1;

            Baglanti.Close();

        }




        //cikis işlemi
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
