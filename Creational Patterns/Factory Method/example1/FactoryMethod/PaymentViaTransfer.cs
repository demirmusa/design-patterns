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
