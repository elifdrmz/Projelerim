using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler
{
    class DersNotu
    {
       

        Ogrenci Ogrenci = new Ogrenci();
        

        public void NotSonuc()
        {
            double ortalama=(Ogrenci.DersNotu1 + Ogrenci.DersNotu2) / 2;

            if (ortalama<50)
            {
                Console.WriteLine("Kaldiniz"); 
            }
            else if (ortalama>=50)
            {
                Console.WriteLine("Gectiniz");
            }
        
        }

    }
}
