namespace Builder
{
    public class PizzaMargheritaDirector
    {
        public void ConstructPizza(PizzaBuilder pizzaBuilder)
        {
            pizzaBuilder.NameThePizza("Pizza Margherita");
            pizzaBuilder.SetDoughRadius(15);

            pizzaBuilder.AddDoughIngredient(new Ingredient("bread flour", 250));
            pizzaBuilder.AddDoughIngredient(new Ingredient("oil", 20));
            pizzaBuilder.AddDoughIngredient(new Ingredient("warm-water", 200));
            pizzaBuilder.AddDoughIngredient(new Ingredient("sourdough", 0.5));
            pizzaBuilder.AddDoughIngredient(new Ingredient("salt", 10));
            pizzaBuilder.AddDoughIngredient(new Ingredient("sugar", 10));

            pizzaBuilder.AddSauceIngredients(new Ingredient("tomato", 4));
            pizzaBuilder.AddSauceIngredients(new Ingredient("oil", 50));
            pizzaBuilder.AddSauceIngredients(new Ingredient("thyme", 10));

            pizzaBuilder.AddExtraIngredient(new Ingredient("mozzarella", 400));
            pizzaBuilder.AddExtraIngredient(new Ingredient("basil", 4));
        }
    }

    public class MixedPizzaDirector
    {
        public void ConstructPizza(PizzaBuilder pizzaBuilder)
        {
            pizzaBuilder.NameThePizza("Mixed Pizza");
            pizzaBuilder.SetDoughRadius(20);

            pizzaBuilder.AddDoughIngredient(new Ingredient("warm-water", 355));
            pizzaBuilder.AddDoughIngredient(new Ingredient("active-dry-yeast", 1));
            pizzaBuilder.AddDoughIngredient(new Ingredient("bread-flour", 490));
            pizzaBuilder.AddDoughIngredient(new Ingredient("olive oil", 20));
            pizzaBuilder.AddDoughIngredient(new Ingredient("salt", 10));
            pizzaBuilder.AddDoughIngredient(new Ingredient("sugar", 10));

            pizzaBuilder.AddSauceIngredients(new Ingredient("tomato", 4));
            pizzaBuilder.AddSauceIngredients(new Ingredient("oil", 50));
            pizzaBuilder.AddSauceIngredients(new Ingredient("thyme", 10));
            pizzaBuilder.AddSauceIngredients(new Ingredient("onion", 0.5));
            pizzaBuilder.AddSauceIngredients(new Ingredient("carrot", 0.5));
            pizzaBuilder.AddSauceIngredients(new Ingredient("small-stalk-of-celery", 1));
            pizzaBuilder.AddSauceIngredients(new Ingredient("parsley", 2));
            pizzaBuilder.AddSauceIngredients(new Ingredient("basil ", 2));

            pizzaBuilder.AddExtraIngredient(new Ingredient("mozzarella", 200));
            pizzaBuilder.AddExtraIngredient(new Ingredient("Pepperoni", 100));
            pizzaBuilder.AddExtraIngredient(new Ingredient("basil", 4));
            pizzaBuilder.AddExtraIngredient(new Ingredient("Feta-cheese", 4));
            pizzaBuilder.AddExtraIngredient(new Ingredient("Pesto", -1));//-1 is as many as you want
            pizzaBuilder.AddExtraIngredient(new Ingredient("Ham", -1));
            pizzaBuilder.AddExtraIngredient(new Ingredient("Mushrooms", -1));
            pizzaBuilder.AddExtraIngredient(new Ingredient("cooked-sausage", -1));
        }
    }
}
