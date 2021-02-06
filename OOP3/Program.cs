using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalCreditManager = new PersonalCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager mortgageLoanManager = new MortgageLoanManager();

            IloggerService databaseLoggerService = new DatabaseLoggerService();
            IloggerService fileLoggerService = new FileLoggerService();

            ReferenceManager referenceManager = new ReferenceManager();
            referenceManager.ToApply(transportCreditManager, databaseLoggerService);
                                     //seçilen kredi hesaplama seçilen database loglama
          
            List<ICreditManager> credits = new List<ICreditManager>() {personalCreditManager,mortgageLoanManager };

            //referenceManager.MakeCreditAdvanceNotification(credits);
        }
    }
}
