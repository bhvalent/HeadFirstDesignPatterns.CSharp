namespace SimUDuckApp.FlyBehavior
{
    public class FlyNoWay : ICanFly
    {
        public void Fly() => Console.WriteLine("I can't fly");
    }
}
