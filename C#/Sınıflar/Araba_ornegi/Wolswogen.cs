using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Araba_ornegi
{
    class Wolswogen
    {
        public int WolswogenID { get; set; }
        public string Passat { get; set; }
        public string Golf { get; set; }
        public string Polo { get; set; }
        public Araba araba { get; set; }

        
        ArrayList wolswogenler { get; set; } = new ArrayList();

        public ArrayList WolswogenEkle(Wolswogen wolswogen)
        {
            //Wolswogen wolswogen = new Wolswogen();
            //wolswogen.WolswogenID = 3;
            ArrayList wolswogenler1 = new ArrayList();
            wolswogenler1.Add(wolswogen.Passat);
            wolswogenler1.Add(araba.KapiSayisi = 5);
            wolswogenler1.Add(araba.Motorgucu = 100);
            wolswogenler1.Add(araba.VitesTuru = "manuel");
            wolswogenler1.Add(araba.YakitTuru = "dizel");
            wolswogenler1.Add(araba.YapimYili = 2005);
            wolswogenler1.Add(araba.KaportaCinsi = "sedan");
            wolswogenler.Add(wolswogenler1);

            ArrayList wolswogenler2 = new ArrayList();
            wolswogenler2.Add(wolswogen.Golf);
            wolswogenler2.Add(araba.KapiSayisi = 3);
            wolswogenler2.Add(araba.Motorgucu = 120);
            wolswogenler2.Add(araba.VitesTuru = "otomatik");
            wolswogenler2.Add(araba.YakitTuru = "benzin");
            wolswogenler2.Add(araba.YapimYili = 2015);
            wolswogenler2.Add(araba.KaportaCinsi = "hecbeck");
            wolswogenler.Add(wolswogenler2);

            ArrayList wolswogenler3 = new ArrayList();
            wolswogenler3.Add(wolswogen.Polo);
            wolswogenler3.Add(araba.KapiSayisi = 5);
            wolswogenler3.Add(araba.Motorgucu = 100);
            wolswogenler3.Add(araba.VitesTuru = "otomatik");
            wolswogenler3.Add(araba.YakitTuru = "dizel");
            wolswogenler3.Add(araba.YapimYili = 2017);
            wolswogenler3.Add(araba.KaportaCinsi = "hecbeck");
            wolswogenler.Add(wolswogenler3);

            return wolswogenler;
        }

        public void WolswogenGoster()
        {
            foreach (var item in wolswogenler)
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
