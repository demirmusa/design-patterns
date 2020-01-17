using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            double productFee = 99.9;

            PaymentFactory paymentFactory = new PaymentFactory();

            var paymentMethod = paymentFactory.GetPaymentMethod(PaymentType.Bitcoin);
            if (paymentMethod.TryCharge(productFee))
            {
                Console.WriteLine("Paid via Bitcoin");
                return;
            }

            paymentMethod = paymentFactory.GetPaymentMethod(PaymentType.CreditCard);
            if (paymentMethod.TryCharge(productFee))
            {
                Console.WriteLine("Paid via CreditCard");
                return;
            }

            paymentMethod = paymentFactory.GetPaymentMethod(PaymentType.Transfer);
            if (paymentMethod.TryCharge(productFee))
            {
                Console.WriteLine("Paid via Transfer");
                return;
            }

            throw new Exception("But I wanted it so much :(");
        }
    }
}
