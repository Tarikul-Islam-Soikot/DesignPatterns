using StrategyPattern;

List<string> list = new List<string>() { "b", "a",  "c" };
var context = new Context();

IStrategy strategyA = new ConcreteStrategyA();
context.SetStrategy(strategyA);
context.ConcatStringList(list);

Console.WriteLine(context.ConcatStringList(list));

IStrategy strategyB = new ConcreteStrategyB();
context.SetStrategy(strategyB);
context.ConcatStringList(list);

Console.WriteLine(context.ConcatStringList(list));

