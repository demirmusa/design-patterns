namespace FactoryMethod
{
    public interface IPaymentMethod
    {
        bool TryCharge(double amount);
    }
}
