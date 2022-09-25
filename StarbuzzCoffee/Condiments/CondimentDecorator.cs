using StarbuzzCoffee.Beverages;

namespace StarbuzzCoffee.Condiments
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage Beverage { get; init; }

        public abstract override string Description { get; }

        public CondimentDecorator(Beverage beverage)
        {
            Beverage = beverage;
        }
    }
}
