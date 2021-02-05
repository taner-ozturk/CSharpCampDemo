using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalCreditManager = new PersonalCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager mortgageLoanManager = new MortgageLoanManager();

            ReferenceManager referenceManager = new ReferenceManager();
            referenceManager.ToApply(transportCreditManager);

        }
    }
}
