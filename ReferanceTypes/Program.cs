using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            //int decimal,foloat,enum, boolean      value types(değer tipler) 
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 100;

            Console.WriteLine("Sayi 1 :" + sayi1);
        }
    }
}
