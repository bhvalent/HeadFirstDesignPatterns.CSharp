using SimUDuckApp.FlyBehavior;
using SimUDuckApp.QuackBehavior;

namespace SimUDuckApp.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck() : base(new FlyNoWay(), new RealQuack()) { }

        public override void Display() => Console.WriteLine("I'm a model duck");
    }
}
