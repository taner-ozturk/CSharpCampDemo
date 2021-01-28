using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için Temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C#";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için Temel kurs", "Java", "Python", "C#" };




            for (int i = 0; i < kurslar.Length; i++)  // i sayaç anlamına geliyor
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar) //dizi temelli yapıları tek tek dönmeye yarıyor in kurları dolaş demek foreach diziliere uygulanır
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
