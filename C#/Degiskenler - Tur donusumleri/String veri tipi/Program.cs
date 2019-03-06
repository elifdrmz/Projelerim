using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_veri_tipi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("String \n Veri \n Türü");

            //string tanımlama (16bit*karakter "" arasında tanımlanır)
            string veri = "Merhaba Dünya";

                        //Kaçış karakterleri
            //-----------------------------
            // \" => Ekrana -" yazar.
            // \t => arada bir tab kadar boşluk bırakacaktır.
            // \n => Alt satıra geçer.
            // \r => İmleci satır başına çeker.

            Console.WriteLine("\"Mehmet\"\tAyan\nSmartPro Bilgisayar Akademisi\rAraba");

            Console.WriteLine("C:\\Users\\İsim.Soyisim");


            // Değişken Tanımlama örneği:
            string name;
            name = "elif";
            Console.WriteLine(name);

           










        }
            }
}
