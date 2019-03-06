using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _31._12._2018_Bankamatik
{
    class Program
    {
        static void Main(string[] args)
        {

            string username = "";
            string password = "";

            do
            {
                giris: Console.Clear();
                Console.WriteLine("Banka Giriş Ekranı");
                Console.WriteLine("------------------------");
                Console.WriteLine(" 1. Giriş");
                Console.WriteLine(" 2. Kayıt Ol");
                Console.WriteLine(" 3. Şifremi Unuttum");
                Console.WriteLine(" 4. Çıkış");
                Console.WriteLine("------------------------");
                Console.Write("Yapmak istediğiniz işlemi seçin:");
                string secim = Console.ReadLine();



                switch (secim)
                {



                    #region girisekrani

                    case "1":

                        int hak = 1;
                        do
                        {
                            Console.Write(" Kullanıcı Adı: ");
                            string _kullaniciAdi = Console.ReadLine();
                            Console.Write(" Sifre        : ");
                            string _sifre = Console.ReadLine();

                            if (_kullaniciAdi == username && _sifre == password)
                            {
                                Console.WriteLine("Giris basarili");
                                goto hesaplara;
                            }
                            else
                            {
                                Console.WriteLine("Kullanici adi veya sifre hatalı, Tekrar deneyiniz");
                            }

                            hak++;

                        } while (hak <= 3);

                        Thread.Sleep(3000);

                        Console.WriteLine("Giris basarisiz!");

                        goto kayitol;

                        break;
                    #endregion



                    #region kayitekrani
                    case "2":
                        kayitol: do
                        {
                            string hata = "";
                            bool isValid = true;
                            Console.Clear();
                            Console.WriteLine("Banka Kayıt Ekranı");
                            Console.WriteLine("------------------------");
                            Console.Write(" Kullanıcı Adı: ");
                            string kullaniciAdi = Console.ReadLine();
                            Console.Write(" Sifre        : ");
                            string sifre = Console.ReadLine();
                            Console.Write(" Sifre Tekrar : ");
                            string sifreTekrar = Console.ReadLine();

                            //Kullanici adi kontrol
                            #region Kullanici Kontrol
                            if (kullaniciAdi.Length < 6)
                            {
                                hata = hata + "Kullanici adi 5 karakterden fazla olmali\n";
                                isValid = false;
                            }
                            #endregion

                            //sifre kontrol
                            #region Sifre Kontrol
                            if (sifre == sifreTekrar)
                            {
                                //sifre karakter uzunluğu
                                if (sifre.Length < 6)
                                {
                                    hata = hata + "Sifre 5 den buyuk olmali\n";
                                    isValid = false;
                                }
                                //sifrenin rakam içermesi
                                string rakamlar = "0123456789";
                                bool rakamVarmi = false;
                                for (int i = 0; i < rakamlar.Length; i++)
                                {
                                    for (int k = 0; k < sifre.Length; k++)
                                    {
                                        if (rakamlar.Substring(i, 1) == sifre.Substring(k, 1))
                                        {
                                            rakamVarmi = true;
                                            break;
                                        }
                                    }
                                    if (rakamVarmi)
                                    {
                                        break;
                                    }
                                }
                                //for çıkışı
                                if (rakamVarmi == false)
                                {
                                    hata = hata + "Sifre en az bir rakam icermeli\n";
                                    isValid = false;
                                }
                            }
                            else
                            {
                                hata = hata + "Sifreniz uyumsuz\n";
                                isValid = false;
                            }
                            #endregion
                            if (isValid)
                            {
                                //Kayıt Başarılı
                                username = kullaniciAdi;
                                password = sifre;
                                Console.Clear();
                                Console.WriteLine("Kayıt Başarılı. Yönlendiriliyorsunuz...");
                                Thread.Sleep(2000);
                                break;
                            }
                            Console.WriteLine(hata);

                        } while (true);
                        break;
                    #endregion

                    #region sifredegistir
                    case "3":

                        yeniad: Console.Write("Kullanici adinizi giriniz=");
                        string yeniad = Console.ReadLine();

                        if (yeniad == username)
                        {
                            yenisifre: Console.WriteLine("Lutfen sifre olustur");
                            Console.Write("sifre giriniz=");
                            string yenisifre = Console.ReadLine();

                            Console.Write("tekrar sifre giriniz=");
                            string yenisifre2 = Console.ReadLine();

                            if (yenisifre == yenisifre2)
                            {
                                password = yenisifre;
                                Console.WriteLine("sifreniz basarili sekilde degismistir:)");
                                goto giris;
                            }

                            else
                            {
                                Console.WriteLine("sifre uyumsuz");
                                goto yenisifre;
                            }
                        }

                        else
                        {
                            hak = 0;
                            do
                            {
                                Console.WriteLine("Kullanici hatali");
                                goto yeniad;
                                hak++;


                            } while (hak<3);

                            //hakkı bitir ekle unutma******************************************************************

                            Console.WriteLine("islem sonlanmistir");
                        }

                        break; 
                        #endregion


                }
            } while (true);
            

            

        hesaplara:
            

            #region BankaParaEklemeÇekme

            //Banka paraları
            int ikiyuz = 50;
            int yuz = 50;
            int elli = 50;
            int yirmi = 50;
            int on = 50;
            int bes = 50;
            int bir = 50;

            //benim paralarım
            int _ikiyuz = 0;
            int _yuz = 1;
            int _elli = 0;
            int _yirmi = 0;
            int _on = 0;
            int _bes = 0;
            int _bir = 0;


            //Benim bakiye
            int bakiye = 659;

            string cikis = "";
            do
            {
                Console.Clear();
                //---------------------------

                #region Anakod

                Console.WriteLine("Hosgeldiniz         {0}", username);

                Console.WriteLine("1. Bakiye Göster");
                Console.WriteLine("2. Para Çekme");
                Console.WriteLine("3. Para Yatırma");
                Console.WriteLine("4. Para Gönderme");
                Console.WriteLine("5. Bankadaki Para Adetlerini Göster");
                Console.WriteLine("-------------------------------------");
                Console.Write("Yapmak istediğiniz işlemi seçin:");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":

                        int temp = bakiye;

                        #region KendiBanknotelarimiHesaplama
                        _ikiyuz = temp / 200;
                        if (_ikiyuz != 0)
                        {
                            temp = temp % 200;
                        }

                        _yuz = temp / 100;
                        if (_yuz != 0)
                        {
                            temp = temp % 100;
                        }

                        _elli = temp / 50;
                        if (_elli != 0)
                        {
                            temp = temp % 50;
                        }

                        _yirmi = temp / 20;
                        if (_yirmi != 0)
                        {
                            temp = temp % 20;
                        }

                        _on = temp / 10;
                        if (_on != 0)
                        {
                            temp = temp % 10;
                        }

                        _bes = temp / 5;
                        if (_bes != 0)
                        {
                            temp = temp % 5;
                        }

                        _bir = temp / 1;
                        if (_bir != 0)
                        {
                            temp = temp % 1;
                        }
                        #endregion

                        Console.WriteLine("Bakiyeniz: {0}", bakiye);
                        Console.WriteLine("ikiyuz :{0}", _ikiyuz);
                        Console.WriteLine("yuz :{0}", _yuz);
                        Console.WriteLine("elli :{0}", _elli);
                        Console.WriteLine("yirmi :{0}", _yirmi);
                        Console.WriteLine("on :{0}", _on);
                        Console.WriteLine("bes :{0}", _bes);
                        Console.WriteLine("bir :{0}", _bir);

                        break;

                    case "2":
                        Console.Write("Çekmek istediğiniz tutar:");
                        int tutar = int.Parse(Console.ReadLine());

                        bakiye = bakiye - tutar;
                        temp = tutar; ;

                        #region BankaBanknotelariniHesaplama
                        temp = tutar;
                        int a;
                        a = temp / 200;
                        if (a != 0)
                        {
                            temp = temp % 200;
                            ikiyuz = ikiyuz - a;

                        }

                        a = temp / 100;
                        if (a != 0)
                        {
                            temp = temp % 100;
                            yuz = yuz - a;
                        }

                        a = temp / 50;
                        if (a != 0)
                        {
                            temp = temp % 50;
                            elli = elli - a;
                        }

                        a = temp / 20;
                        if (a != 0)
                        {
                            temp = temp % 20;
                            yirmi = yirmi - a;
                        }

                        a = temp / 10;
                        if (a != 0)
                        {
                            temp = temp % 10;
                            on = on - a;
                        }

                        a = temp / 5;
                        if (a != 0)
                        {
                            temp = temp % 5;
                            bes = bes - a;
                        }

                        a = temp / 1;
                        if (a != 0)
                        {
                            temp = temp % 1;
                            bir = bir - a;

                        }
                        #endregion
                        break;

                    case "3":
                        Console.Write("Eklemek istediğiniz tutar:");
                        int tutarEkleme = int.Parse(Console.ReadLine());

                        bakiye = bakiye + tutarEkleme;
                        temp = tutarEkleme;

                        #region BankaBanknotelariniHesaplama2

                        a = temp / 200;
                        if (a != 0)
                        {
                            temp = temp % 200;
                            ikiyuz = ikiyuz + a;

                        }

                        a = temp / 100;
                        if (a != 0)
                        {
                            temp = temp % 100;
                            yuz = yuz + a;
                        }

                        a = temp / 50;
                        if (a != 0)
                        {
                            temp = temp % 50;
                            elli = elli + a;
                        }

                        a = temp / 20;
                        if (a != 0)
                        {
                            temp = temp % 20;
                            yirmi = yirmi + a;
                        }

                        a = temp / 10;
                        if (a != 0)
                        {
                            temp = temp % 10;
                            on = on + a;
                        }

                        a = temp / 5;
                        if (a != 0)
                        {
                            temp = temp % 5;
                            bes = bes + a;
                        }

                        a = temp / 1;
                        if (a != 0)
                        {
                            temp = temp % 1;
                            bir = bir + a;

                        }
                        #endregion

                        break;

                    case "5":

                        Console.WriteLine(" Banka Bakisi:");
                        Console.WriteLine("ikiyuz :{0}", ikiyuz);
                        Console.WriteLine("yuz :{0}", yuz);
                        Console.WriteLine("elli :{0}", elli);
                        Console.WriteLine("yirmi :{0}", yirmi);
                        Console.WriteLine("on :{0}", on);
                        Console.WriteLine("bes :{0}", bes);
                        Console.WriteLine("bir :{0}", bir);
                        break;
                }
                #endregion



                //----------------------------
                Console.WriteLine("Çıkmak istyor musunuz (e/h)");
                cikis = Console.ReadLine();
            } while (cikis != "e");
            #endregion









        }
    }
}
