using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Araba_ornegi
{
    class Audi
    {
        public int AudiID { get; set; }
        public string Q7 { get; set; }
        public string TTR{ get; set; }
        public string A5 { get; set; }
        public Araba araba { get; set; }

      
        ArrayList audiler { get; set; } = new ArrayList();

        public ArrayList AudiEkle(Audi audi)
        {
            //Audi audi = new Audi();
            //audi.AudiID = 2;
            ArrayList audiler1 = new ArrayList();
            audiler1.Add(audi.Q7);
            audiler1.Add(araba.KapiSayisi = 3);
            audiler1.Add(araba.Motorgucu = 120);
            audiler1.Add(araba.VitesTuru = "otomatik");
            audiler1.Add(araba.YakitTuru = "dizel");
            audiler1.Add(araba.YapimYili = 2018);
            audiler1.Add(araba.KaportaCinsi = "hecbeck");
            audiler.Add(audiler1);

            ArrayList audiler2 = new ArrayList();
            audiler2.Add(audi.TTR);
            audiler2.Add(araba.KapiSayisi = 5);
            audiler2.Add(araba.Motorgucu = 120);
            audiler2.Add(araba.VitesTuru = "otomatik");
            audiler2.Add(araba.YakitTuru = "dizel");
            audiler2.Add(araba.YapimYili = 2019);
            audiler2.Add(araba.KaportaCinsi = "hecbeck");
            audiler.Add(audiler2);

            ArrayList audiler3 = new ArrayList();
            audiler3.Add(audi.A5);
            audiler3.Add(araba.KapiSayisi = 3);
            audiler3.Add(araba.Motorgucu = 100);
            audiler3.Add(araba.VitesTuru = "manuel");
            audiler3.Add(araba.YakitTuru = "dizel");
            audiler3.Add(araba.YapimYili = 2018);
            audiler3.Add(araba.KaportaCinsi = "sedan");
            audiler.Add(audiler3);

            return audiler;
        }

        public void AudiGoster()
        {
            foreach (var item in audiler)
            {
                Console.WriteLine("modeli: ");
                Console.WriteLine("Kapi sayisi: ");
                Console.WriteLine("Motor gucu: ");
                Console.WriteLine("Vites gucu: ");
                Console.WriteLine("Yakit turu: ");
                Console.WriteLine("Yapim yili: ");
                Console.WriteLine("Kaporta cinsi: ");
            }
       
        }



    }
}
