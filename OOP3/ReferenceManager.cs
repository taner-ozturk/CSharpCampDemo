using System;
using System.Collections.Generic;

namespace OOP3
{
    class ReferenceManager
    {
        public void ToApply(ICreditManager creditManager, IloggerService loggerService)
        {
            //
            creditManager.Calculate();
            loggerService.Log();
        }
        
        public void MakeCreditAdvanceNotification(List<ICreditManager> credits)
        
        {
            foreach (var credit in credits)

            {
                credit.Calculate();
            }

        }
    }
}
