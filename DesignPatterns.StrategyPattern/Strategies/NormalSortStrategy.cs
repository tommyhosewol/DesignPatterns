namespace DesignPatterns.StrategyPattern.Strategies;

public class NormalSortStrategy : IStrategy
{
    public object DoAlgoritm(object data)
    {
        var list = data as List<string>;
        list?.Sort();

        return list ?? data;
    }
}