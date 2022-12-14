// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;

var deliveryBox = new DeliveryBox();

Console.WriteLine("An order has been placed!\n");

var gpuBox = new SmallBox(new GraphicsCard());
var hammerBox = new SmallBox(new Hammer());
var ramBox = new SmallBox(new Ram());

deliveryBox.Add(gpuBox);
deliveryBox.Add(hammerBox);
deliveryBox.Add(ramBox);

var totalCost = deliveryBox.CalculatePrice();
Console.WriteLine($"The total cost of everything is: {totalCost} $");