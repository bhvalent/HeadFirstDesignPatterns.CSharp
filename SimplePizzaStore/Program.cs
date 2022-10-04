using SimplePizzaStore;

var pizzaFactory = new SimplePizzaFactory();
var pizzaStore = new PizzaStore(pizzaFactory);

pizzaStore.OrderPizza(PizzaType.Cheese);
pizzaStore.OrderPizza(PizzaType.Pepperoni);