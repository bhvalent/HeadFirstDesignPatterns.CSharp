namespace PizzaFranchise
{
    public abstract class Pizza
    {
        public string Name { get; set; } = string.Empty;
        public string Dough { get; set; } = string.Empty;
        public string Sauce { get; set; } = string.Empty;
        public List<string> Toppings { get; set; } = new List<string>(); 

        public void Prepare() 
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine($"Tossing {Dough}");
            Console.WriteLine($"Adding {Sauce}");
            Console.WriteLine($"Adding toppings: ");
            foreach (var topping in Toppings)
            {
                Console.WriteLine($"\t{topping}");
            }
        }

        public virtual void Bake() 
        {
            Console.WriteLine("Bake for 25min at 350");
        }

        public virtual void Cut() 
        {
            Console.WriteLine("Cutting pizza into diagnal pieces.");
        }

        public virtual void Box() 
        {
            Console.WriteLine("Placing pizza in official box.");
        }
    }
}
