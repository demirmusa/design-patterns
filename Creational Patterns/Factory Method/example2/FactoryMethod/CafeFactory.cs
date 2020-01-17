using System;

namespace FactoryMethod
{
    public class CafeFactory
    {
        public ICafe GetCafe(CoffeeType coffeeType)
        {
            switch (coffeeType)
            {
                case CoffeeType.AmericanoCoffee:
                    return new Starbucks();
                case CoffeeType.TurkishCoffee:
                    return new KahveDunyasi();
                default:
                    throw new ArgumentOutOfRangeException(nameof(coffeeType), coffeeType, null);
            }
        }
    }
}
