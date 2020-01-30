using System.Collections.Generic;

namespace Builder
{
    public class PizzaDough
    {
        public double Radius { get; set; }

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public void RollOutTheDough()
        {
            MixIngredients();
            RollOut();
        }

        private void MixIngredients()
        {
            //...
        }

        private void RollOut()
        {
            /*            
            while (GetCurrentRadius() <= Radius)
            {
                //rollout
            }
            */
        }
    }
}
