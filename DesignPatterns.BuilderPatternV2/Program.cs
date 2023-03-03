using System.Drawing;
using DesignPatterns.BuilderPatternV2.Cars;

var carBuilder = new CarBuilder();
var myNewlyBuiltCar = carBuilder
    .SetBrand(Brand.Mercedes)
    .AddAxle()
    .AddAxle()
    .SetColor(Color.Red)
    .Build();
    
Console.WriteLine($"My new car is a {myNewlyBuiltCar.Color.Name} {myNewlyBuiltCar.Brand}, it has {myNewlyBuiltCar.Axles.Count} axles.");