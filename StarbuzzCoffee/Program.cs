using StarbuzzCoffee.Beverages;
using StarbuzzCoffee.Condiments;

var beverageOne = new Espresso();
Console.WriteLine($"{beverageOne.Description} ${beverageOne.Cost}");

Beverage beverageTwo = new DarkRoast();
beverageTwo = new Mocha(beverageTwo);
beverageTwo = new Mocha(beverageTwo);
beverageTwo = new Whip(beverageTwo);
Console.WriteLine($"{beverageTwo.Description} ${beverageTwo.Cost}");

Beverage beverageThree = new HouseBlend();
beverageThree = new Soy(beverageThree);
beverageThree = new Mocha(beverageThree);
beverageThree = new Whip(beverageThree);
Console.WriteLine($"{beverageThree.Description} ${beverageThree.Cost}");