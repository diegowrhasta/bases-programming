// See https://aka.ms/new-console-template for more information

using DummyLibrary;

var roundHole = new RoundHole
{
    Radius = 5,
};
var roundPeg = new RoundPeg
{
    Radius = 5,
};

Console.WriteLine(roundHole.Fits(roundPeg));

var smallSquarePeg = new SquarePeg
{
    Width = 5,
};
var smallSquarePegAdapter = new SquarePegAdapter(smallSquarePeg);
var largeSquarePeg = new SquarePeg
{
    Width = 10,
};
var largeSquarePegAdapter = new SquarePegAdapter(largeSquarePeg);

Console.WriteLine(roundHole.Fits(smallSquarePegAdapter));
Console.WriteLine(roundHole.Fits(largeSquarePegAdapter));
