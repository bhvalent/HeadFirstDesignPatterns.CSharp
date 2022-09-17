namespace SimUDuckApp.QuackBehavior
{
    public class RealQuack : ICanQuack
    {
        public void Quack() => Console.WriteLine("Quack!");
    }
}
