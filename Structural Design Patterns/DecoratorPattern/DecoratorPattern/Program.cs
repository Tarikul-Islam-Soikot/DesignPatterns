using CoffeeDecoratorPattern.Implementation;
using CoffeeDecoratorPattern.Interface;


SimpleCoffee simpleCoffee = new SimpleCoffee();

Console.WriteLine(simpleCoffee.GetDescription());
Console.WriteLine(simpleCoffee.GetPrice());

ICoffee sugarCoffee = new SugarDecorator(simpleCoffee);
Console.WriteLine(sugarCoffee.GetDescription());
Console.WriteLine(sugarCoffee.GetPrice());

ICoffee sugarCoffeeWithMilk = new MilkDecorator(sugarCoffee);
Console.WriteLine(sugarCoffeeWithMilk.GetDescription());
Console.WriteLine(sugarCoffeeWithMilk.GetPrice());