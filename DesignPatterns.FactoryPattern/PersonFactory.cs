using DesignPatterns.FactoryPattern.Persons;

namespace DesignPatterns.FactoryPattern;

public static class PersonFactory
{
    public static MalePerson CreateMaleNamedSteve()
    {
        return new MalePerson
        {
            Name = "Steve"
        };
    }
    
    public static FemalePerson CreateFemaleNamedAlex()
    {
        return new FemalePerson
        {
            Name = "Alex"
        };
    }
}