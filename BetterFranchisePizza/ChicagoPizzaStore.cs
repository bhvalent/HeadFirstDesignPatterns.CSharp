using BetterFranchisePizza;

namespace BetterFranchisePizza
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza? CreatePizza(PizzaType type)
        {
            var ingredientFactory = new ChicagoPizzaIngredientFactory();

            Pizza? pizza = null;
            if (type is PizzaType.Cheese)
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "Chicago Style Cheese Pizza";
            }
            return pizza;
        }
    }
}
