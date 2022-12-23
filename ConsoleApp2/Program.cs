// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;
using DummyLibrary.Models;

var payDetails = new PayPayload
{
    AmountPaid = 500,
    ClientName = "Diego",
    ClientType = ClientType.Normal,
    OrderCost = 456
};

Console.WriteLine(payDetails);
var payOrder = new PayOrder(payDetails);
payOrder.Execute();