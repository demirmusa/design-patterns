namespace FactoryMethod
{
    public class PaymentViaCreditCard : IPaymentMethod
    {
        public bool TryCharge(double amount)
        {
            //not implemented
            return false;
        }
    }
}
