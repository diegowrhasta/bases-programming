using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class Rectangle : IShape
{
    public double Height { get; set; }
    public double Width { get; set; }

    public double GetArea() => Height * Width;
}