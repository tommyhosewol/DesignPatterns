using System.Drawing;
using DesignPatterns.BuilderPattern.Cars;

var carBuilder = new CarBuilder();
var myNewlyBuiltCar = carBuilder
    .SetBrand(Brand.Mercedes)
    .AddAxle()
    .AddAxle()
    .SetColor(Color.Blue)
    .Build();
    
Console.WriteLine($"My new car is a {myNewlyBuiltCar.Color.Name} {myNewlyBuiltCar.Brand}, it has {myNewlyBuiltCar.Axles.Count} axles.");