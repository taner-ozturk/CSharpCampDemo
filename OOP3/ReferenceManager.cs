using System;
namespace OOP3
{
    class ReferenceManager
    {
        public void ToApply(ICreditManager creditManager)
        {
            //
            creditManager.Calculate();
        }

        public void MakeCreditAdvanceNotification()
        {

        }
    }
}
