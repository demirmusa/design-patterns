using System;
using System.Collections.Generic;

namespace Builder
{
    public class Pizza
    {
        public string Name { get; set; }

        public PizzaDough Dough { get; set; } = new PizzaDough();

        public PizzaSauce Sauce { get; set; } = new PizzaSauce();

        public List<Ingredient> ExtraIngredients { get; set; } = new List<Ingredient>();
        
        public void SpreadTheSauceToDough()
        {
            //...
        }

        public void SpreadTheExtraIngredientsToTop()
        {
            //...
        }

        public void PrintIngredients()
        {
            Console.WriteLine(Environment.NewLine + "----------------------------------------------" + Environment.NewLine);

            Console.WriteLine($"Pizza Name: {Name} is ready to cook." +
                              Environment.NewLine
                              + $"Radius :{Dough.Radius}" +
                              Environment.NewLine + Environment.NewLine +
                              "Ingredients:" +
                              Environment.NewLine);

            Console.WriteLine("Dough:");
            Dough.Ingredients.ForEach(i => i.PrintInfo());

            Console.WriteLine(Environment.NewLine + "Sauce:");
            Sauce.Ingredients.ForEach(i => i.PrintInfo());

            Console.WriteLine(Environment.NewLine + "Top:");
            ExtraIngredients.ForEach(i => i.PrintInfo());

            Console.WriteLine(Environment.NewLine + "----------------------------------------------" + Environment.NewLine);
        }
    }
}
