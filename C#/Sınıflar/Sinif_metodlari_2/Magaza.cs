using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Sinif_metodlari_2
{
    class Magaza
    {

        public int MagazaID { get; set; }
        public string MagazaAdi { get; set; }
        
        public ArrayList Urunler { get; set; } = new ArrayList();

        Urun urun = new Urun();

        public void UrunlerEkle()
        {
            string secim = "";
            do
            {
               
                Console.Write("Urun ID  :");
                urun.UrunNo = int.Parse(Console.ReadLine());
                Console.Write("Urun Adi  :");
                urun.Urunİsmi = Console.ReadLine();
                Console.Write("Urun Fiyati  :");
                urun.UrunFiyat = int.Parse(Console.ReadLine());
                Console.Write("Urun Adeti  :");
                urun.UrunAdet = int.Parse(Console.ReadLine());

                Console.Write("Urununuz basarili bir sekilde eklendi  ");
                Console.WriteLine("Baska ekleme yapmak istiyor musunuz? (e/h)");
                secim = Console.ReadLine();

            } while (secim.ToLower()=="e");

        }

             public void UrunEkle(Urun urun)
        {
            Urunler.Add(urun);
        }

        
        //urunsat 

        public bool UrunSat(int id)
        {
            int stok =urun.UrunAdet;

            bool urunvarmi = false;
           

                foreach (var item in Urunler)
                {
        
                     if (((Urun)item).UrunNo == id)
                     {

                         if (((Urun)item).UrunAdet>0)
                         {
                             urunvarmi = true;
                             break;
                        
                             ((Urun)item).UrunAdet--;
                         }
                        
                   
                     } 
                }
                
                return urunvarmi;
        }





    }
}
