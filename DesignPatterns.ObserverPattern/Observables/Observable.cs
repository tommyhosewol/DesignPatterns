using DesignPatterns.ObserverPattern.Observers;

namespace DesignPatterns.ObserverPattern.Observables;

public abstract class Observable : IObservable
{
    private readonly List<IObserver> _observers = new();

    public void AddObserver(IObserver observer)
    {
        Console.WriteLine($"Added {nameof(observer)} to observers.");
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        Console.WriteLine($"Removed {nameof(observer)} from observers.");
        if (_observers.Contains(observer))
            _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        Console.WriteLine($"Notifying observers");
        _observers.ForEach(observer => observer.Update());
    }
}