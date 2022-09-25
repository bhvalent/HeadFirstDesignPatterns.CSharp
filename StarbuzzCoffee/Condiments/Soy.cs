using StarbuzzCoffee.Beverages;

namespace StarbuzzCoffee.Condiments
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage) : base(beverage) { }

        public override string Description => $"{Beverage.Description}, Soy";

        public override double Cost => Beverage.Cost + 0.15;
    }
}
