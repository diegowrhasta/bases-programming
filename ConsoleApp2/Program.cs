// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;

Console.WriteLine("Please select a type of car you want:");
Console.WriteLine("1. Sports Car");
Console.WriteLine("2. Vintage Car");

if (!int.TryParse(Console.ReadLine(), out var option))
{
    return;
}

var builder = new CarBuilder();
var director = new Director(builder);

switch (option)
{
    case (int)CarType.SportsCar:
        director.MakeSportsCar();
        break;
    case (int)CarType.VintageCar:
        director.MakeVintageCar();
        break;
    default:
        break;
}

var car = builder.GetCar();

Console.WriteLine($"This is your car:\n\n{car.ToString()}");