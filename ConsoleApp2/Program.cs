// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;

var rectangles = new object[]
{
    new Rectangle{ Height = 10, Width = 10, },
    new Rectangle{ Height = 20, Width = 10, },
    new Rectangle{ Height = 30, Width = 10, },
    new Circle { Radius = 10, },
};

var totalArea = AreaCalculator.TotalArea(rectangles);

Console.WriteLine($"Total Area is {totalArea}");