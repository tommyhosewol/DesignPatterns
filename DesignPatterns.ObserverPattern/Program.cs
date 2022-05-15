// See https://aka.ms/new-console-template for more information

using DesignPatterns.ObserverPattern.Observables;
using DesignPatterns.ObserverPattern.Observers;

var person = new ObservablePerson("Mary-Anne");
person.AddObserver(new PersonObserver());

person.Name = "Johan";
