using System.Collections.Immutable;
using System.Text;
using DummyLibrary.Extensions;
using DummyLibrary.Interfaces;
using DummyLibrary.Models;

namespace DummyLibrary.Classes;

public class PayOrder : IOrder
{
    private static readonly IImmutableDictionary<ClientType, decimal> DiscountsDictionary =
        new Dictionary<ClientType, decimal>
        {
            { ClientType.Normal, decimal.Zero },
            { ClientType.Vip, 0.10m },
            { ClientType.Usual, 0.33m },
        }.ToImmutableDictionary();
    private readonly PayPayload _orderParams;

    public PayOrder(PayPayload orderParams)
    {
        _orderParams = orderParams;
    }

    public void Execute()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append($"Pay Order received, type of customer is {_orderParams.ClientType}.\n");
        stringBuilder.Append($"The total cost of the order is {_orderParams.OrderCost.ToString("C2")}.\n");
        stringBuilder.AppendWhen(
            () => _orderParams.ClientType != ClientType.Normal,
            builder => builder.Append($"The discount is {_orderParams.ClientType}.\n"));

        var change = _orderParams.AmountPaid - _orderParams.OrderCost -
                       _orderParams.OrderCost * DiscountsDictionary[_orderParams.ClientType];
        change = Math.Abs(change);
        stringBuilder.Append($"The change is {change.ToString("C2")}.");
        Console.WriteLine(stringBuilder);
    }
}