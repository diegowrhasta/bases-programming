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

switch (productOption)
{
    case (int)ProductType.Chair:
        var chair = factory.CreateChair();
        chair.SitOn();
        break;
    case (int)ProductType.CoffeeTable:
        var coffeeTable = factory.CreateCoffeeTable();
        coffeeTable.SitOn();
        break;
    case (int)ProductType.Sofa:
        var sofa = factory.CreateSofa();
        sofa.SitOn();
        break;
    default:
        break;

}