using StarbuzzCoffee.Beverages;

namespace StarbuzzCoffee.Condiments
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage) { }

        public override string Description => $"{Beverage.Description}, Whip";

        public override double Cost => Beverage.Cost + 0.10;
    }
}
