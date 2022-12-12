// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;

Console.WriteLine("Please select the product you want:");
Console.WriteLine("1. Car");
Console.WriteLine("2. Car Flyer");

if (!int.TryParse(Console.ReadLine(), out var option))
{
    return;
}

switch (option)
{
    case (int)ProductType.Car:
        SelectCar();
        break;
    case (int)ProductType.Flyer:
        SelectFlyer();
        break;
}

static void SelectCar()
{
    Console.WriteLine("Please select a type of car you want:");
    Console.WriteLine("1. Sports Car");
    Console.WriteLine("2. Vintage Car");

    if (!int.TryParse(Console.ReadLine(), out var option))
    {
        return;
    }

    var builder = new CarBuilder();
    var director = new CarDirector(builder);

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
}

static void SelectFlyer()
{
    Console.WriteLine("Please select a type of flyer you want:");
    Console.WriteLine("1. Normal Flyer");
    Console.WriteLine("2. Big Flyer");

    if (!int.TryParse(Console.ReadLine(), out var option))
    {
        return;
    }

    var builder = new FlyerBuilder();
    var director = new FlyerDirector(builder);

    switch (option)
    {
        case (int)FlyerType.BigFlyer:
            director.MakeBigFlyer();
            break;
        case (int)FlyerType.NormalFlyer:
            director.MakeNormalFlyer();
            break;
        default:
            break;
    }

    var flyer = builder.GetFlyer();

    Console.WriteLine($"{flyer.ToString()}");
}