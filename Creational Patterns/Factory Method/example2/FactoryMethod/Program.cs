namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            GiveMeATurkishCoffee();
            GiveMeAnAmericano();
        }

        static void GiveMeATurkishCoffee()
        {
            var cafeFactory = new CafeFactory();

            var cafe = cafeFactory.GetCafe(CoffeeType.TurkishCoffee);
            cafe.ServeCoffee();
        }

        static void GiveMeAnAmericano()
        {
            var cafeFactory = new CafeFactory();

            var cafe = cafeFactory.GetCafe(CoffeeType.AmericanoCoffee);
            cafe.ServeCoffee();
        }
    }
}
