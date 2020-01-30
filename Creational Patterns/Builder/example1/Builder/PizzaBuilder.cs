namespace Builder
{
    public class PizzaBuilder
    {
        private Pizza _pizza;

        public PizzaBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _pizza = new Pizza();
        }

        public void NameThePizza(string name)
        {
            _pizza.Name = name;
        }

        public void AddDoughIngredient(Ingredient ingredient)
        {
            _pizza.Dough.Ingredients.Add(ingredient);
        }

        public void AddSauceIngredients(Ingredient ingredient)
        {
            _pizza.Sauce.Ingredients.Add(ingredient);
        }

        public void AddExtraIngredient(Ingredient ingredient)
        {
            _pizza.ExtraIngredients.Add(ingredient);
        }

        public void SetDoughRadius(double radius)
        {
            _pizza.Dough.Radius = radius;
        }

        public Pizza PreparePizza()
        {
            _pizza.Dough.RollOutTheDough();
            //...
            _pizza.Sauce.MixIngredients();
            _pizza.SpreadTheSauceToDough();
            //...
            _pizza.SpreadTheExtraIngredientsToTop();

            var pizza = _pizza;
            Reset();
            return pizza;
        }
    }
}
