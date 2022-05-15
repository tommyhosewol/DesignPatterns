using DesignPatterns.StrategyPattern.Strategies;

namespace DesignPatterns.StrategyPattern;

public class Context
{
    private IStrategy _strategy;

    public Context()
    {
    }

    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Act()
    {
        Console.WriteLine("Context: Sorting data using the strategy (not sure how it will do that).");
        var result = _strategy.DoAlgoritm(new List<string> {"a", "b", "e", "c", "d"});

        Console.WriteLine(string.Join(", ", (result as List<string> ?? new List<string>())));
    }
}