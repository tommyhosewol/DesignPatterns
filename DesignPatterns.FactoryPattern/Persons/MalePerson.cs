namespace DesignPatterns.FactoryPattern.Persons;

public class MalePerson : IPerson
{
    public override void Speak()
    {
        Console.WriteLine($"I am a male named {Name}");
    }
}