using SimUDuckApp.FlyBehavior;
using SimUDuckApp.QuackBehavior;

namespace SimUDuckApp.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck() : base(new FlyWithWings(), new RealQuack()) { }

        public override void Display() => Console.WriteLine("I am a Mallard Duck!");
    }
}
