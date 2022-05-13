using System.Drawing;

namespace DesignPatterns.BuilderPattern.Cars;

public class Car
{
    public List<Axle> Axles = new();
    public Color Color;
    public Brand Brand;
}

public enum Brand
{
    Mercedes,
    BMW,
    Audi
}

public class Axle { }