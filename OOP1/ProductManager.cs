using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)// void ne işe yarıyor? //kullanılamaz sonuç elde etmek için void kullanırım.
            //elde edilen sonucu başka bir yerde kullanmak istersem void kullanmam.
        {

            Console.WriteLine(product.ProductName + "eklendi.");

        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }



        //public int Topla(int sayi1, int sayi2)
        //{
          //  return sayi1 + sayi2;
        //}
        //public void Topla2(int sayi1, int sayi2)
        //{
          //  Console.WriteLine(sayi1 + sayi2);
        //}

    }
}
