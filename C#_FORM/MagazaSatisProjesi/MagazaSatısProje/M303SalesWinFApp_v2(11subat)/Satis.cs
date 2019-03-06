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
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }

        SqlConnection Baglanti = new SqlConnection("Data Source=PC-BILGISAYAR;Initial Catalog=M303SalesDB;Integrated Security=True");

        class personel
        {
            public int ID1 { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }

            public override string ToString()
            {
                return ID1+"- "+ Ad +"  "+Soyad;
            }
        }

        class musteri
        {
            public int ID2 { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public override string ToString()
            {
                return ID2 + "- " +FirstName + "  " + LastName;
            }
        }

        class urun
        {
            public int ID3 { get; set; }
            public string UName { get; set; }
            public int Adet { get; set; }
           
            public override string ToString()
            {
                return ID3 + "- " + UName;
               
            }
                   
        }



        //sql den verileri almak için
        private void Satis_Load(object sender, EventArgs e)
        {
            //combobox1 a sql den veri çekme -->personel
            SqlCommand md1 = new SqlCommand();
            md1.CommandText = "Select *from Employees";
            md1.Connection = Baglanti;
            md1.CommandType = CommandType.Text;
            SqlDataReader dr1;
            Baglanti.Open();
            dr1 = md1.ExecuteReader();

            while (dr1.Read())
            {
                personel item = new personel();
                item.ID1 = int.Parse(dr1["EmployeeID"].ToString());
                item.Ad = dr1["Ad"].ToString();
                item.Soyad = dr1["Soyad"].ToString();

                comboBox1.Items.Add(item);

            }
            Baglanti.Close();

            //ComboBox2 a sql den veri çekme --->müşteri

            SqlCommand md2 = new SqlCommand();
            md2.CommandText = "Select *from Customers";
            md2.Connection = Baglanti;
            md2.CommandType = CommandType.Text;
            SqlDataReader dr2;
            Baglanti.Open();
            dr2 = md2.ExecuteReader();

            while (dr2.Read())
            {
                musteri item = new musteri();
                item.ID2 = int.Parse(dr2["CustomerID"].ToString());
                item.FirstName = dr2["FirstName"].ToString();
                item.LastName = dr2["LastName"].ToString();

                comboBox2.Items.Add(item);

            }
            Baglanti.Close();


            //ComboBox3 a sql den veri çekme --->ürün

            SqlCommand md3 = new SqlCommand();
            md3.CommandText = "Select *from Products";
            md3.Connection = Baglanti;
            md3.CommandType = CommandType.Text;
            SqlDataReader dr3;
            Baglanti.Open();
            dr3 = md3.ExecuteReader();

            while (dr3.Read())
            {
                urun item = new urun();
                item.ID3 = int.Parse(dr3["ProductID"].ToString());
                item.UName = dr3["Name"].ToString();

                //ürün adeti yazdırmak için
                item.Adet = int.Parse(dr3["Quantity"].ToString());

                comboBox3.Items.Add(item);
            }
            Baglanti.Close();
        }

    
        //personelID sini label a yazdırmak için 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            personel item = (personel)comboBox1.SelectedItem;
            label5.Text = item.ID1.ToString();
        }


        //müşteriID sini label a yazdırmak için 
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            musteri item = (musteri)comboBox2.SelectedItem;
            label6.Text = item.ID2.ToString();
        }

        //ürünID sini label a yazdırmak için 
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            urun item = (urun)comboBox3.SelectedItem;
            label7.Text = item.ID3.ToString();

            //ürün adetini label8 e yazdırmak için
            label8.Text = item.Adet.ToString();

            //comboBox4 e ürün adetlerini yazdırmak için
            for (int i = 1; i <= Convert.ToInt32(label8.Text); i++)
            {
                comboBox4.Items.Add(i);
            }

        }
        
        
      

        //Satış yap butonu --> sales tablosuna verileri atmak için 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Baglanti.Open();

                SqlCommand SatisEkle = new SqlCommand("insert into Sales(salesPersonID,CustomerID,productID,Quantity) values(@p1,@p2,@p3,@p4)", Baglanti);
                SatisEkle.Parameters.AddWithValue("@p1", label5.Text);
                SatisEkle.Parameters.AddWithValue("@p2", label6.Text);
                SatisEkle.Parameters.AddWithValue("@p3", label7.Text);
                SatisEkle.Parameters.AddWithValue("@p4", comboBox4.Text);

                SatisEkle.ExecuteNonQuery();
               
               
                //ürün adetini güncellemek için 
              
                label9.Text = (Convert.ToInt32(label8.Text) - Convert.ToInt32(comboBox4.Text)).ToString();
               
                SqlCommand urunAdetGuncelle = new SqlCommand("update Products set Quantity='"+ label9.Text+ "' where ProductID='"+label7.Text+"'", Baglanti);
                
                urunAdetGuncelle.ExecuteNonQuery();
                Baglanti.Close();

                //comboBox ları temizlemek
                comboBox1.Enabled = false; comboBox2.Enabled = false; comboBox3.Enabled = false; comboBox4.Enabled = false;

                MessageBox.Show("Satış işlemi başarılı olarak gerçekleşmiştir...");

                

            }
            catch (Exception)
            {
                MessageBox.Show("Satış başarısız olmuştur...");
            }
          

        }


        //satışa devam butonu-->
        private void button3_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            Satis satis = new Satis();
            satis.Show();

        }



        //çıkış işlemi için
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

      
    }
}
