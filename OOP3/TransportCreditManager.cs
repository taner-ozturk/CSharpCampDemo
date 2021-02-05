using System;
namespace OOP3
{
    class TransportCreditManager : ICreditManager
    {
        public void Calculate()
        {
            //
            //
            Console.WriteLine("Taşıt kredisi hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
