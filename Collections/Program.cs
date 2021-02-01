using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Emre", "Ali", "Kazım", "Türker","Taner" };



            foreach (var isim in isimler)// dizide varolan her bir elemanı almak için kullandığımız yegane yöntem.

            {
                //Console.WriteLine(isim);
            }
           
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            List<string> isimler2 = new List<string> { "Emre", "Ali", "Kazım", "Türker", "Taner" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);
            


            isimler2.Add("İlker");//diziler yerine listeleri kullandığım için burada eleman eklemen kolay ve mümkün.
            Console.WriteLine(isimler2[5]);
            Console.WriteLine(isimler2[0]);

           

        }
    }
}
