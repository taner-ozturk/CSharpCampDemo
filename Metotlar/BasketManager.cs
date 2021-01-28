using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class BasketManager
    {
        //naming convetion
        //syntax

        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + product.Name);

        }
        public void Add2(string productName, string Info, double Price, int Stock)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + productName);

        }
    }
}
