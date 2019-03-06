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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string connStr_Local = @"Data Source=303-P04;Initial Catalog=M303SalesDB;User ID=sa;Password=1234";

        public string AdSoyad;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connLocal = new SqlConnection();

            connLocal.ConnectionString = connStr_Local;

            connLocal.Open();

            string userName = tboxUserName.Text.Trim();
            string userPass = tboxUserPass.Text.Trim();

            SqlCommand cmd = new SqlCommand("SELECT Ad,Soyad,UserName,UserPass FROM Employees WHERE UserName='" + userName + "'AND UserPass='" + userPass + "' AND Kul_Tipi='Admin'", connLocal);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {

                //adsoyad yazdırma için
                AdSoyad = "KayitEkrani"+ "   " + "Hosgeldin" + "   " + dt.Rows[0]["Ad"].ToString() + "   " + dt.Rows[0]["Soyad"].ToString();
                KayitEkrani kayitekrani = new KayitEkrani();
                kayitekrani.Show();

                kayitekrani.satışToolStripMenuItem.Enabled = false;

                kayitekrani.Text = AdSoyad;
                this.Hide();
               

            }
            else
            {
                MessageBox.Show("Giriş işlemi başarısız...Lütfen bilgilerinizi kontrol ediniz ve tekrar deneyiniz...");
                tboxUserName.Clear();
                tboxUserPass.Clear();

            }

            connLocal.Close();
        }


        //Kullanici girişi için

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection connLocal = new SqlConnection();

            connLocal.ConnectionString = connStr_Local;

            connLocal.Open();

            string userName = textBox1.Text.Trim();
            string userPass = textBox2.Text.Trim();

            SqlCommand cmd = new SqlCommand("SELECT Ad,Soyad,UserName,UserPass FROM Employees WHERE UserName='" + userName + "'AND UserPass='" + userPass + "' AND Kul_Tipi='Kullanici'", connLocal);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {

                //adsoyad yazdırma için
                AdSoyad = "KayitEkrani" + "   " + "Hosgeldin" + "   " + dt.Rows[0]["Ad"].ToString() + "   " + dt.Rows[0]["Soyad"].ToString();
              

                KayitEkrani kayitekrani2 = new KayitEkrani();
                kayitekrani2.Show();

                //burda kayit ekraninda kullanici girişi yapan ayarlara giremesin diye
                kayitekrani2.ayarlarToolStripMenuItem.Enabled = false;
                
                kayitekrani2.Text = AdSoyad;


                this.Hide();

             
            }

            else
            {
                MessageBox.Show("Giriş işlemi başarısız...Lütfen bilgilerinizi kontrol ediniz ve tekrar deneyiniz...");
                textBox1.Clear();
                textBox2.Clear();

            }

            connLocal.Close();
            
            


        }
    }
}


