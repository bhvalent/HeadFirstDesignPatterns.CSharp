using StarbuzzCoffee.Beverages;

namespace StarbuzzCoffee.Condiments
{
    public class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage beverage) : base(beverage) { }

        public override string Description => $"{Beverage.Description}, Steamed Milk";

        public override double Cost => Beverage.Cost + 0.10;
    }
}
