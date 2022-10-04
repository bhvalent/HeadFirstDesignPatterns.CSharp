namespace PizzaFranchise
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza? CreatePizza(PizzaType type)
        {
            Pizza? pizza = null;
            if (type is PizzaType.Cheese)
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            return pizza;
        }
    }
}
