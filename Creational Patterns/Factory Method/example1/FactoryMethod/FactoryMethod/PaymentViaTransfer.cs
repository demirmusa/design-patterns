using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class PaymentViaTransfer : IPaymentMethod
    {
        public bool TryCharge(double amount)
        {
            //not implemented
            return false;
        }
    }
}
