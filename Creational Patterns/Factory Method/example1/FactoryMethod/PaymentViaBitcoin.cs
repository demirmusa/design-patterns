using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class PaymentViaBitcoin : IPaymentMethod
    {
        public bool TryCharge(double amount)
        {
            return false;
        }
    }
}
