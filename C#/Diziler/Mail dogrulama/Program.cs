using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_dogrulama
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Email adresini giriniz.");
            //Console.Write("Email adresi: ");
            //string email = "msos13.A@ abc.com";
            //int sayac = 0;
            //bool isValid = true;
            //for (int i = 0; i < email.Length; i++)
            //{
            //    if (email.Substring(i, 1) == "@")
            //    {
            //        sayac++;
            //    }
            //}
            ////@ var
            //if (sayac == 1)
            //{
            //    string[] dizi = email.Split('@');
            //    string sag = dizi[1];
            //    string sol = dizi[0];
            //    ////sadece  bit tane @ varsa
            //    if (dizi.Length == 2)
            //    {
            //        //Sag-------------------------
            //        bool sonNet = sag.EndsWith(".net");
            //        bool sonCom = sag.EndsWith(".com");
            //        if (sonNet || sonCom)
            //        {
            //            int lastIndexNokta = sag.LastIndexOf('.');
            //            if (lastIndexNokta > 0)
            //            {
            //                int sayacSagOzel = 0;
            //                for (int i = 0; i < lastIndexNokta; i++)
            //                {
            //                    char[] dizi3 = sag.ToCharArray();
            //                    if (dizi3[i] < 'a' || dizi3[i] > 'z')
            //                    {
            //                        sayacSagOzel++;
            //                    }
            //                }
            //                if (sayacSagOzel > 0)
            //                {
            //                    isValid = false;
            //                }
            //            }
            //            else
            //            {
            //                isValid = false;
            //            }

            //        }
            //        else
            //        {
            //            isValid = false;
            //        }


            //        //Sol-------------------------
            //        //1. Koşul Uzunluk en az 6 karakter
            //        if (sol.Length >= 6)
            //        {
            //            //2.Koşul en az bir rakam gerekli
            //            char[] dizi2 = sol.ToCharArray();
            //            int rakamSayac = 0;
            //            int buyukHarfSayac = 0;
            //            int ozelKarakterSayac = 0;
            //            int boslukSayac = 0;
            //            for (int i = 0; i < dizi2.Length; i++)
            //            {
            //                if ('0' <= dizi2[i] && dizi2[i] <= '9')
            //                {
            //                    rakamSayac++;
            //                }
            //                //3.koşul en az bir tane büyük harf gerekli
            //                if ('A' <= dizi2[i] && dizi2[i] <= 'Z')
            //                {
            //                    buyukHarfSayac++;
            //                }
            //                if ('.' == dizi2[i] || dizi2[i] == '_')
            //                {
            //                    ozelKarakterSayac++;
            //                }
            //                if (' ' == dizi2[i])
            //                {
            //                    boslukSayac++;
            //                }
            //            }
            //            if (rakamSayac == 0 || buyukHarfSayac == 0 || ozelKarakterSayac == 0 || boslukSayac > 0)
            //            {
            //                isValid = false;
            //            }
            //        }
            //        else
            //        {
            //            isValid = false;
            //        }
            //    }
            //    else
            //    {
            //        //Sadece @ var
            //        isValid = false;
            //    }
            //}
            ////@ yok veya birden fazla var
            //else
            //{
            //    isValid = false;
            //}
            //Console.WriteLine("{0}   {1}", email, isValid);




        }
    }
}
