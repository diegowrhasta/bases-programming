// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes.Factories;
using DummyLibrary.Classes.Products;
using DummyLibrary.Interfaces;

Console.WriteLine("Please select what style of Furniture you want...");
Console.WriteLine("1. Art Deco");
Console.WriteLine("2. Modern");
Console.WriteLine("3. Victorian");

if (!int.TryParse(Console.ReadLine(), out var styleOption))
{
    return;
}

IProductFactory? factory = styleOption switch
{
  (int)FurnitureStyle.Modern => new ModernFactory(),
  (int)FurnitureStyle.Victorian => new VictorianFactory(),
  (int)FurnitureStyle.ArtDeco => new ArtDecoFactory(),
  _ => null,
};

if (factory is null)
{
    return;
}

Console.WriteLine("Please select what product type you want...");
Console.WriteLine("1. Chair");
Console.WriteLine("2. Coffee Table");
Console.WriteLine("3. Sofa");

if (!int.TryParse(Console.ReadLine(), out var productOption))
{
    return;
}

IProduct? product = productOption switch
{
    (int)ProductType.Chair => factory.CreateChair(),
    (int)ProductType.CoffeeTable => factory.CreateCoffeeTable(),
    (int)ProductType.Sofa => factory.CreateSofa(),
    _ => null,
};

if (product is null)
{
    return;
}

product.SitOn();