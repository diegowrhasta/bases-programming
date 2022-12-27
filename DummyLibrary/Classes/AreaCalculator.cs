namespace DummyLibrary.Classes;

public static class AreaCalculator
{
    public static double TotalArea(Rectangle[] rectangles) => rectangles.Sum(rectangle => rectangle.Height * rectangle.Width);
}