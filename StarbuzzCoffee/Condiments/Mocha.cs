using StarbuzzCoffee.Beverages;

namespace StarbuzzCoffee.Condiments
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage) { }

        public override string Description => $"{Beverage.Description}, Mocha";

        public override double Cost => Beverage.Cost + 0.20;
    }
}
