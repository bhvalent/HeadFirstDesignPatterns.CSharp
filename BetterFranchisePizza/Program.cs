using BetterFranchisePizza;

var nyStore = new NYPizzaStore();
var chicagoStore = new ChicagoPizzaStore();

Pizza pizza = nyStore.OrderPizza(PizzaType.Cheese);
Console.WriteLine($"Ethan ordered a {pizza}");

pizza = chicagoStore.OrderPizza(PizzaType.Cheese);
Console.WriteLine($"Joel ordered a {pizza}");