namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBuilder pizzaBuilder = new PizzaBuilder();

            var pizzaMargheritaDirector = new PizzaMargheritaDirector();
            pizzaMargheritaDirector.ConstructPizza(pizzaBuilder);

            var pizzaMargherita = pizzaBuilder.PreparePizza();
            pizzaMargherita.PrintIngredients();

            var mixedPizzaDirector = new MixedPizzaDirector();
            mixedPizzaDirector.ConstructPizza(pizzaBuilder);

            var mixedPizza = pizzaBuilder.PreparePizza();
            mixedPizza.PrintIngredients();
        }
    }
}
