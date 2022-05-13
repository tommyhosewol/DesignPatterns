using DesignPatterns.FactoryPattern;

var person = PersonFactory.CreateMaleNamedSteve();
person.Speak();

var secondPerson = PersonFactory.CreateFemaleNamedAlex();
secondPerson.Speak();