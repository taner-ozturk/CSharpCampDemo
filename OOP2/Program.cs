using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerçek müşteri
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "1";
            customer1.Name = "Taner";
            customer1.SurName = "Öztürk";
            customer1.TcNu = "234234234";


            //Tüzel müşteri
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "214234";
            customer2.CompanyName = "nadide.kehribar";
            customer2.TaxNumber = "23452345";


            // Customer gerçek ve tüzel müşterileri tutar. Individual and Corparate
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

        }
    }
}
