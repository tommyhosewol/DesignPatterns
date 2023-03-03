using System.Diagnostics;
using System.Drawing;

namespace DesignPatterns.BuilderPatternV2.Cars;

public class CarBuilder
{
    private List<Action<Car>> _actions = new List<Action<Car>>();

    public CarBuilder AddAxle()
    {
        _actions.Add(car => car.Axles.Add(new Axle()));
        return this;
    }

    public CarBuilder RemoveAxle()
    {
        _actions.Add(car => car.Axles.RemoveAt(-1));
        return this;
    }

    public CarBuilder SetBrand(Brand brand)
    {
        _actions.Add(car => car.Brand = brand);
        return this;
    }

    public CarBuilder SetColor(Color color)
    {
        _actions.Add(car => car.Color = color);
        return this;
    }

    public Car Build()
    {
        var car = new Car();
        _actions.ForEach(action => action.Invoke(car));
        return car;
    }
}