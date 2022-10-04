namespace SimplePizzaStore
{
    public class PepperoniPizza : IAmPizza
    {
        public void Bake()
        {
            Console.WriteLine("Bake for 25min at 350");
        }

        public void Box()
        {
            Console.WriteLine("Placing Pizza in Official Box.");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting Pepperoni Pizza.");
        }

        public void Prepare()
        {
            Console.WriteLine("Preparing Pepperoni Pizza.");
        }
    }
}
