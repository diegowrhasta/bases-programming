using System.Text;

namespace DummyLibrary.Models;

public class PayPayload
{
    public decimal OrderCost { get; set; }
    public string? ClientName { get; set; }
    public decimal AmountPaid { get; set; }
    public ClientType ClientType { get; set; } = ClientType.Normal;

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append($"Client: {ClientName}\n");
        stringBuilder.Append($"Order Cost: {OrderCost}\n");
        stringBuilder.Append($"Amount Paid: {AmountPaid}\n");

        return stringBuilder.ToString();
    }
}