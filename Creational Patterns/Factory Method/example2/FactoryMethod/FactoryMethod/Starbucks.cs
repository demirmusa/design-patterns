using System;

namespace FactoryMethod
{
    public class Starbucks : ICafe
    {
        public void ServeCoffee()
        {
            Console.WriteLine("Starbucks has served a coffee");
        }
    }
}
