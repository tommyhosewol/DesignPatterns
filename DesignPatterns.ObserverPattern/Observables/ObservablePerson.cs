namespace DesignPatterns.ObserverPattern.Observables;

public class ObservablePerson : Observable
{
    private string _name;

    public ObservablePerson(string name)
    {
        _name = name;
        Console.WriteLine($"Person with name {_name} was born.");
    }

    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            NotifyObservers();
        }
    }
}