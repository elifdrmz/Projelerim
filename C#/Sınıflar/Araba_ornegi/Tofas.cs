using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Araba_ornegi
{
    class Tofas
    {
        public int TofasID { get; set; }
        public string Kartal { get; set; }
        public string Sahin { get; set; }
        public string Dogan { get; set; }
        public Araba araba { get; set; }

     
        
        ArrayList tofaslar { get; set; } = new ArrayList();

       public ArrayList TofaslariEkle(Tofas tofas)
        {
            //Tofas tofas = new Tofas();
            //tofas.TofasID = 1;
            ArrayList tofaslar1 = new ArrayList();
            tofaslar1.Add(tofas.Dogan);
            tofaslar1.Add(araba.KapiSayisi = 5);
            tofaslar1.Add(araba.Motorgucu = 90);
            tofaslar1.Add(araba.VitesTuru = "otomatik");
            tofaslar1.Add(araba.YakitTuru = "benzin");
            tofaslar1.Add(araba.YapimYili = 2010);
            tofaslar1.Add(araba.KaportaCinsi = "sedan");
            tofaslar.Add(tofaslar1);

            ArrayList tofaslar2 = new ArrayList();
            tofaslar2.Add(tofas.Kartal);
            tofaslar2.Add(araba.KapiSayisi = 5);
            tofaslar2.Add(araba.Motorgucu = 80);
            tofaslar2.Add(araba.VitesTuru = "manuel");
            tofaslar2.Add(araba.YakitTuru = "dizel");
            tofaslar2.Add(araba.YapimYili = 2008);
            tofaslar2.Add(araba.KaportaCinsi = "sedan");
            tofaslar.Add(tofaslar2);

            ArrayList tofaslar3 = new ArrayList();
            tofaslar3.Add(tofas.Sahin);
            tofaslar3.Add(araba.KapiSayisi = 5);
            tofaslar3.Add(araba.Motorgucu = 100);
            tofaslar3.Add(araba.VitesTuru = "manuel");
            tofaslar3.Add(araba.YakitTuru = "benzin");
            tofaslar3.Add(araba.YapimYili = 2002);
            tofaslar3.Add(araba.KaportaCinsi = "sedan");
            tofaslar.Add(tofaslar3);
            
            return tofaslar;
        }

        public void TofasGoster()
        {
            foreach (var item in tofaslar)
            {
                Console.WriteLine($"modeli: ");
                Console.WriteLine($"Kapi sayisi:{((Araba)item).KapiSayisi} ");
                Console.WriteLine($"Motor gucu: {((Araba)item).Motorgucu}");
                Console.WriteLine($"Vites turu: {((Araba)item).VitesTuru}");
                Console.WriteLine($"Yakit turu: {((Araba)item).YakitTuru}");
                Console.WriteLine($"Yapim yili: {((Araba)item).YapimYili}");
                Console.WriteLine($"Kaporta cinsi: {((Araba)item).KaportaCinsi}");
            }

        }


    }
}
