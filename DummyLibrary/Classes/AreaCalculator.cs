namespace DummyLibrary.Classes;

public static class AreaCalculator
{
    public static double TotalArea(IEnumerable<object> shapes)
    {
        var totalArea = 0d;
        foreach (var shape in shapes)
        {
            switch (shape)
            {
                case Rectangle castedRectangle:
                    totalArea += castedRectangle.Height * castedRectangle.Width;
                    break;
                case Circle castedCircle:
                    totalArea += castedCircle.Radius * castedCircle.Radius * Math.PI;
                    break;
            }
        }

        return totalArea;
    }
}