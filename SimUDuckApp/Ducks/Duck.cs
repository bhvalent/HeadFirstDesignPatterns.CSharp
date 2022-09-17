using SimUDuckApp.FlyBehavior;
using SimUDuckApp.QuackBehavior;

namespace SimUDuckApp.Ducks
{
    public abstract class Duck
    {
        private ICanFly _flyBehavior;
        private ICanQuack _quackBehavior;

        public Duck(ICanFly flyBehavior, ICanQuack quackBehavior) 
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
        }

        public abstract void Display();

        public void SetFlyBehavior(ICanFly flyBehavior) => _flyBehavior = flyBehavior;

        public void SetQuackBehavior(ICanQuack quackBehavior) => _quackBehavior = quackBehavior;

        public void PerformQuack() => _quackBehavior.Quack();

        public void PerformFly() => _flyBehavior.Fly();

        public virtual void Swim() => Console.WriteLine("All ducks float, even decoys!");
    }
}
