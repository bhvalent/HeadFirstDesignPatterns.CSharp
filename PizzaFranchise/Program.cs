using PizzaFranchise;

var nyStore = new NYPizzaStore();
var chicagoStore = new ChicagoPizzaStore();

var nyCheese = nyStore.OrderPizza(PizzaType.Cheese);
Console.WriteLine($"Ethan ordered a {nyCheese?.Name}");

var chicagoCheese = chicagoStore.OrderPizza(PizzaType.Cheese);
Console.WriteLine($"Joel ordered a {chicagoCheese?.Name}");