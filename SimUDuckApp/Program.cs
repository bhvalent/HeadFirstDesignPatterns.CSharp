// this is the body of the main method
using SimUDuckApp.Ducks;
using SimUDuckApp.FlyBehavior;

Duck mallard = new MallardDuck();
mallard.PerformQuack();
mallard.PerformFly();

Duck model = new ModelDuck();
model.PerformFly();
model.SetFlyBehavior(new JetPack());
model.PerformFly();