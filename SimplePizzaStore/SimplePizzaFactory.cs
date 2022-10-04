namespace SimplePizzaStore
{
    public class SimplePizzaFactory
    {
        public IAmPizza? createPizza(PizzaType type)
        {
            IAmPizza? pizza = null;
            if (type is PizzaType.Cheese)
            {
                pizza =  new CheesePizza();
            } 
            else if (type is PizzaType.Pepperoni)
            {
                pizza = new PepperoniPizza();
            }
            return pizza;
        }
    }
}
