using DesignPatterns.StrategyPattern;
using DesignPatterns.StrategyPattern.Strategies;

var context = new Context();

Console.WriteLine("Client: Strategy is set to normal sorting.");
context.SetStrategy(new NormalSortStrategy());
context.Act();

Console.WriteLine();

Console.WriteLine("Client: Strategy is set to reversed sorting.");
context.SetStrategy(new ReverseSortStrategy());
context.Act();
