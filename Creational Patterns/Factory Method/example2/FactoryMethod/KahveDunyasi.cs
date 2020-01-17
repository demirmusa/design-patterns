using System;

namespace FactoryMethod
{
    public class KahveDunyasi : ICafe
    {
        public void ServeCoffee()
        {
            Console.WriteLine("KahveDunyasi has served a coffee");
        }
    }
}
