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
