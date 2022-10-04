using BetterFranchisePizza;

namespace BetterFranchisePizza
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza? CreatePizza(PizzaType type)
        {
            var ingredientFactory = new NYPizzaIngredientFactory();

            Pizza? pizza = null;
            if (type is PizzaType.Cheese)
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "New York Style Cheese Pizza";
            }
            return pizza;
        }
    }
}
