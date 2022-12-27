using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class Circle : IShape
{
    public double Radius { get; set; }

    public double GetArea() => Radius * Radius * Math.PI;
}