using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            String fruits = new String[] { "Elma", "Karpuz" };

            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Info = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 21;
            product2.Info = "Diyarbakır karpuzu";


            Product[] products = new Product[] { product1, product2 };

            //type-safe -- tip güvenli
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Info);
                Console.WriteLine("--------------------");

            }

            Console.WriteLine("------------------Metotlar----------------------");

            //encapsulation
            //instance - örnek
            BasketManager basketmanager = new BasketManager();
            basketmanager.Add(product1);
            basketmanager.Add(product2);


            basketmanager.Add2("Armut", "Yeşil armut", 12, 23);
            basketmanager.Add2("Elma", "Yeşil elma", 15, 21);
            basketmanager.Add2("Karpuz", "Diyarbakır", 5, 54);

        }
    }
}


// Dont repeat yourself - DRY  - clean Code - Best Practice