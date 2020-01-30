using System;

namespace Builder
{
    public class Ingredient
    {
        public string Name { get; set; }

        public double Quantity { get; set; }

        public Ingredient(string name, double quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Quantity: {Quantity}");
        }
    }
}
