using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public interface IPaymentMethod
    {
        bool TryCharge(double amount);
    }
}
