namespace SimplePizzaStore
{
    public class PizzaStore
    {
        private readonly SimplePizzaFactory _pizzaFactory;

        public PizzaStore(SimplePizzaFactory pizzaFactory)
        {
            _pizzaFactory = pizzaFactory;
        }
        
        public IAmPizza OrderPizza(PizzaType type)
        {
            var pizza = _pizzaFactory.createPizza(type) ?? throw new Exception("Pizza Factory unable to create pizza!!");

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
