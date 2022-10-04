using BetterFranchisePizza.Ingredients;
using System.Text;

namespace BetterFranchisePizza
{
    public abstract class Pizza
    {
        public string Name { get; set; } = string.Empty;
        public IAmDough? Dough { get; set; }
        public IAmSauce? Sauce { get; set; }
        public IAmCheese? Cheese { get; set; }
        public List<string> Toppings { get; set; } = new List<string>();

        public abstract void Prepare();

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

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(Name);
            if (Dough != null) result.AppendLine(Dough.ToString());
            if (Sauce != null) result.AppendLine(Sauce.ToString());
            if (Cheese != null) result.AppendLine(Cheese.ToString());

            return result.ToString();
        }
    }
}
