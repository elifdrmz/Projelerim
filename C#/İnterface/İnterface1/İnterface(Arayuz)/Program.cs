using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface_Arayuz_
{
    class Program
    {
        static void Main(string[] args)
        {

            BangOlufsenTV botv = new BangOlufsenTV();
            ITitle title = (ITitle)botv;  //bir sınıfa birden fazla interface atabildiğimiz için hangisinin özelligini kullanmak istiyorsak onu botv den bu şekilde alırız.
            

        }
    }
}
