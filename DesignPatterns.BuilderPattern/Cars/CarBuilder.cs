using System.Diagnostics;
using System.Drawing;

namespace DesignPatterns.BuilderPattern.Cars;

public class CarBuilder
{
    private Car _car = new Car();

    public CarBuilder AddAxle()
    {
        _car.Axles.Add(new Axle());
        return this;
    }

    public CarBuilder RemoveAxle()
    {
        _car.Axles.RemoveAt(-1);
        return this;
    }

    public CarBuilder SetBrand(Brand brand)
    {
        _car.Brand = brand;
        return this;
    }

    public CarBuilder SetColor(Color color)
    {
        _car.Color = color;
        return this;
    }

    public Car Build() => _car;
}