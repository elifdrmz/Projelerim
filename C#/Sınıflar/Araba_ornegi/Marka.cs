using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Araba_ornegi
{
    class Marka
    {
        public Tofas tofas { get; set; }
        public Wolswogen wolswogen { get; set; }
        public Audi audi { get; set; }

        
        
        
    

        public void MarkaGoster()
        {
            Marka marka = new Marka();
            Console.WriteLine("Audi ID: 1 ");
            Console.WriteLine("Wolswogen ID: 2");
            Console.WriteLine("Tofas ID: 3");
        }
        
   
        



    }
}
