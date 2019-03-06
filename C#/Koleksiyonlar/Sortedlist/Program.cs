
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Sortedlist
{
    class Program
    {
        static void Main(string[] args)
        {


            //------------------------------------Sortedlist---------------------------------------

            SortedList sozluk = new SortedList()

  
            {
            {"yarın", "tomorrow"},
            {"bugün", "today"},
            {"hava", "weather"},
            {"gökyüzü", "sky"},
            {"karlı", "snowy"},
            {"güneşli", "sunny"},
            {"bulutlu", "cloudy"},
            {"açık", "unclouded"},
            {"kapalı", "skyless"},
            };

            //----------------Getbyindex-------------------------------

            object gelen = sozluk.GetByIndex(0);
            string a = gelen as string;


            //------------- indexOf------------------------kacıncı index oldugu

            int index = sozluk.IndexOfKey("açık");
            int index2 = sozluk.IndexOfValue("Tomorrow");

            //----------------setbyindex------------------

            sozluk.SetByIndex(0, "açık");

            //--------------GetValueList-------------------

            IList liste = sozluk.GetValueList();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }


            //---------------clone----------------------------- kopyalama yapar

            //sortedlist sozluk u sss sortedlist e clone yaparsak, sss sortedlist de yapılan degişikler sortedlist sozluk etkilenmez
            object clone = sozluk.Clone();
            SortedList sss = (SortedList)clone;
            sss["kapalı"] = "clone";


            //sortedlist sozluk u yeni sortedlist e atıp yeni sortedlist de yapılan degişikler sortedlist sozluk etkilenir
            SortedList yeni = sozluk;
            yeni["açık"] = "kapalı";

            








        }
    }
}
