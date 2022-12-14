// See https://aka.ms/new-console-template for more information

using DummyLibrary;

Console.WriteLine("Planting 3 trees:");

var treeFactory = new TreeFactory();

var roble = treeFactory.GetTreeType("Roble", "Verde", "Suave");
var pino = treeFactory.GetTreeType("Pino", "Verde Oscuro", "Pinoso");
var roble2 = treeFactory.GetTreeType("Roble", "Verde", "Suave");

var roblePlantado = new Tree
{
    X = 12.34f,
    Y = 33.34f,
    TreeType = roble,
};

var roblePlantado2 = new Tree
{
    X = 10.85f,
    Y = 5.33f,
    TreeType = roble2,
};

var pinoPlantado = new Tree
{
    X = 83.34f,
    Y = 99.34f,
    TreeType = pino,
};

Console.WriteLine(roblePlantado);
Console.WriteLine(roblePlantado2);
Console.WriteLine(pinoPlantado);