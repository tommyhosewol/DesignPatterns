namespace DesignPatterns.FactoryPattern.Persons;

public class FemalePerson : IPerson
{
    public override void Speak()
    {
        Console.WriteLine($"I am a female named {Name}");
    }
}