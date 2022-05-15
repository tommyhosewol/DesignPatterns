namespace DesignPatterns.ObserverPattern.Observers;

public class PersonObserver : IObserver
{
    public void Update()
    {
        Console.WriteLine("PersonObserver: the person I am watching was updated.");
    }
}