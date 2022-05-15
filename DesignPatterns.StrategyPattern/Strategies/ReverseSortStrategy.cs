namespace DesignPatterns.StrategyPattern.Strategies;

public class ReverseSortStrategy : IStrategy
{
    public object DoAlgoritm(object data)
    {
        var list = data as List<string>;
        list?.Sort();
        list?.Reverse();

        return list ?? data;
    }
}