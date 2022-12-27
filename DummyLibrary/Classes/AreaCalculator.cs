using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public static class AreaCalculator
{
    public static double TotalArea(IEnumerable<IShape> shapes) => shapes.Sum(s => s.GetArea());
}