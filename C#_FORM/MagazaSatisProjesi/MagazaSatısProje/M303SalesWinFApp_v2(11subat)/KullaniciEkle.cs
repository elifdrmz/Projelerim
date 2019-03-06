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
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }
         
        SqlConnection Baglanti = new SqlConnection("Data Source=PC-BILGISAYAR;Initial Catalog=M303SalesDB;Integrated Security=True");

      
       //Kullanici ekleme
        private void button1_Click_1(object sender, EventArgs e)
        {

            Baglanti.Open();

            SqlCommand kayitekle = new SqlCommand("insert into Employees(Ad,Soyad,E_Mail,Tel,UserName,UserPass,Kul_Tipi,Dogum_Tarihi,Cinsiyet,Sube) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", Baglanti);

            kayitekle.Parameters.AddWithValue("@p1", textBox1.Text);
            kayitekle.Parameters.AddWithValue("@p2", textBox2.Text);
            kayitekle.Parameters.AddWithValue("@p3", textBox3.Text);
            kayitekle.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            kayitekle.Parameters.AddWithValue("@p5", textBox4.Text);
            kayitekle.Parameters.AddWithValue("@p6", textBox6.Text);
            kayitekle.Parameters.AddWithValue("@p7", comboBox1.SelectedItem.ToString());
            kayitekle.Parameters.AddWithValue("@p8", dateTimePicker1.Value);
            kayitekle.Parameters.AddWithValue("@p9", radioButton1.Text);
            kayitekle.Parameters.AddWithValue("@p10", comboBox2.Text);

            kayitekle.ExecuteNonQuery();


            //dataGridView tablosunda görmek için

            SqlDataAdapter da = new SqlDataAdapter("Select Ad+' '+Soyad as Ad_Soyad,E_Mail,Tel,Sube from Employees",Baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
                        
            Baglanti.Close();

            ////mesaj ver
            //MessageBox.Show("Ekleme işlemi gerçekleşmiştir.");

        }


        //sube secmek için combobox a aktarımı
        private void KullaniciEkle_Load(object sender, EventArgs e)
        {
            SqlCommand SubeEkle = new SqlCommand();
            SubeEkle.CommandText = "Select * from Sehirler";
            SubeEkle.Connection = Baglanti;
            SubeEkle.CommandType = CommandType.Text;
            SqlDataReader dr;

            Baglanti.Open();
            dr = SubeEkle.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["SehirAdi"]);
            }
            Baglanti.Close();
        }



        //cikis islemi

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
    }


}
