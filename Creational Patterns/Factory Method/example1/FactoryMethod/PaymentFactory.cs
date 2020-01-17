using System;

namespace FactoryMethod
{
    public class PaymentFactory
    {
        public IPaymentMethod GetPaymentMethod(PaymentType paymentType)
        {
            switch (paymentType)
            {
                case PaymentType.CreditCard:
                    return new PaymentViaCreditCard();
                case PaymentType.Transfer:
                    return new PaymentViaTransfer();
                case PaymentType.Bitcoin:
                    return new PaymentViaBitcoin();
                default:
                    throw new ArgumentOutOfRangeException(nameof(paymentType), paymentType, null);
            }
        }
    }
}
