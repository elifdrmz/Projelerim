using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;    //bu kütüphaneyi ekledik


namespace formdaSQL_kullanımı_P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //*********izlediğim videoda dataveri tabanında kitaplık altında personel adlı tablodan işlem yapacak o yüzden benim öyle bir sql verim yok kafan karışmasın!!!!! videodaki sql den evde oluştur

     

        SqlConnection baglanti =new SqlConnection("Data Source = 303 - P04; Initial Catalog = M303SalesDB; Persist Security Info=True;User ID = sa"); //data baglanti adresi "" içinde yaz

       

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlDataAdapter (DataSet ile veri tabanı arasındaki köprü olarak tanımlayabiliriz/komut cümleciği olarakta düşünebilinir)
            SqlDataAdapter da = new SqlDataAdapter("Select * from Personel", baglanti);  //Employees=çalışanlar(işlem yapmak istediğin tablo adı)
            DataSet ds = new DataSet();  //sanal bir tablo oluşturduk
            da.Fill(ds);   //SqlDataAdapter'ın içini doldur  DataSet ile (fill içini anlamında)
            dataGridView1.DataSource = ds.Tables[0]; //form1 de oluşturduğum dataGridView1 kaynağı ds içindeki tabloyu sıfırıncı indeksini attık


        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //işleme başlamadan önce bağlantımızı açtık

            SqlCommand kayitekle = new SqlCommand("insert into personel(PersonelNo,PersonelAd,PersonelSoyad,PersonelGorev,PersonelMaas,PersonelSehir,PersonelBilgi) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
            //@p1 yazdik çünkü formdaki textleri uzun uzun yazmamak için bağlanti olarak tanımladik

            kayitekle.Parameters.AddWithValue("@p1", textBox1.Text);
            kayitekle.Parameters.AddWithValue("@p2", textBox2.Text);
            kayitekle.Parameters.AddWithValue("@p3", textBox3.Text);
            kayitekle.Parameters.AddWithValue("@p4", textBox4.Text);
            kayitekle.Parameters.AddWithValue("@p5", textBox5.Text);
            kayitekle.Parameters.AddWithValue("@p6", textBox6.Text);
            kayitekle.Parameters.AddWithValue("@p7", textBox7.Text);


            kayitekle.ExecuteNonQuery(); //ExecuteNonQuery(baglantılar üzerinde yapılan değişikler için yapılan komut)

            baglanti.Close();   //işlem bittikten sonra bağlantımızı kapattık


        }

        //kayıt silme işlemi için personeladini girip silme yaptık
        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kayitsil = new SqlCommand("Delete from personel where PersonelAd=@Ad", baglanti);
            kayitsil.Parameters.AddWithValue("@ad", textBox2.Text);
            kayitsil.ExecuteNonQuery();

            baglanti.Close();
        }

    

        //datagrid click olduğu zaman veriyi textte atmak için
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;     //secilen hücrenin indeksini tutuyor //RowIndex(satırindeksini)

            string No = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string Ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string Soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            string Gorev = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            string Maas = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            string Sehir = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            string Bilgi = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            textBox1.Text = No;
            textBox2.Text = Ad;
            textBox3.Text = Soyad;
            textBox4.Text = Gorev;
            textBox5.Text = Maas;
            textBox6.Text = Sehir;
            textBox7.Text = Bilgi;

        }

        //güncellemeyi secilen değere göre yapıyoruz
        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //işleme başlamadan önce bağlantımızı açtık

            SqlCommand kayitguncelle = new SqlCommand("update personel set personel PersonelNo=@p1,PersonelAd=@p2,PersonelSoyad=@p3,PersonelGorev=@p4,PersonelMaas=@p5,PersonelSehir=@p6,PersonelBilgi=@p7 where PersonelNo=@p1", baglanti);

            kayitguncelle.Parameters.AddWithValue("@p1", textBox1.Text);
            kayitguncelle.Parameters.AddWithValue("@p2", textBox2.Text);
            kayitguncelle.Parameters.AddWithValue("@p3", textBox3.Text);
            kayitguncelle.Parameters.AddWithValue("@p4", textBox4.Text);
            kayitguncelle.Parameters.AddWithValue("@p5", textBox5.Text);
            kayitguncelle.Parameters.AddWithValue("@p6", textBox6.Text);
            kayitguncelle.Parameters.AddWithValue("@p7", textBox7.Text);

            kayitguncelle.ExecuteNonQuery();

            baglanti.Close();
        }



        //arama butonuyla textbox8 e girilen PersonelAd ına göre arama yapmak istiyoruz
        private void button5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Personel where PersonelAd='" + textBox8.Text + "'", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            
        }

        //en yüksek maaş göstermek için label9 a yazdırıyoruz
        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select max(PersonelMaas) from Personel", baglanti);
            SqlDataReader oku = komut1.ExecuteReader();  //ExecuteReade(parametreleri oku)
            while (oku.Read())
            {
                label9.Text = oku[0].ToString();
            }
            baglanti.Close();
        }


        //toplam kayıt sayısı label10 a yazdırıyoruz
        private void button7_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(PersonelAd) from Personel", baglanti);
            SqlDataReader oku = komut1.ExecuteReader(); 
            while (oku.Read())
            {
                label10.Text = oku[0].ToString();
            }
            baglanti.Close();
        }



        //toplam maaş label12 ye yazdırıyoruz
        private void button8_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Sum(PersonelMaas) from Personel", baglanti);
            SqlDataReader oku = komut1.ExecuteReader(); 
            while (oku.Read())
            {
                label12.Text = oku[0].ToString();
            }
            baglanti.Close();

        }

        //ortalama maaşları label14 e yazdırıyoruz
        private void button9_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Avg(PersonelMaas) from Personel", baglanti);
            SqlDataReader oku = komut1.ExecuteReader();
            while (oku.Read())
            {
                label14.Text = oku[0].ToString();
            }
            baglanti.Close();
        }
    }
}
