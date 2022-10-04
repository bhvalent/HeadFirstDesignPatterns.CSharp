namespace PizzaFranchise
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(PizzaType type)
        {
            var pizza = CreatePizza(type) ?? throw new Exception("Unable to create pizza!!");

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        public abstract Pizza? CreatePizza(PizzaType type);
    }
}
