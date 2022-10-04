namespace PizzaFranchise
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza? CreatePizza(PizzaType type)
        {
            Pizza? pizza = null;
            if (type is PizzaType.Cheese)
            {
                pizza = new NYStyleCheesePizza();
            }
            return pizza;
        }
    }
}
 