using DesignPatterns.ObserverPattern.Observers;

namespace DesignPatterns.ObserverPattern.Observables;

public interface IObservable
{
    public void AddObserver(IObserver observer);
    public void RemoveObserver(IObserver observer);
    public void NotifyObservers();
}