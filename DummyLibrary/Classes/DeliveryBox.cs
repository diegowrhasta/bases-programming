using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class DeliveryBox : Product
{
    private IList<Product> Products { get; } = new List<Product>();

    internal override string ProductName { get; set; } = "Delivery Box";
    public override double TaxRate { get; set; } = 1.15d;
    public override double UnitCost { get; set; } = 30d;

    public override double CalculatePrice()
    {
        var random = new Random();
        var roll = random.Next();
        (string Carrier, double Cost) shippingInfo = roll % 2 == 0
            ? ("DHL", 10d)
            : ("Fedex", 5d);

        Console.WriteLine($"Delivery is being taken care by {shippingInfo.Carrier}.\nDelivery Cost: {shippingInfo.Cost} $");
        var deliveryBoxPrice = base.CalculatePrice();
        var productsPrice = Products.Sum(p => p.CalculatePrice());
        return shippingInfo.Item2 + productsPrice + deliveryBoxPrice;
    }

    public void Add(Product product) => Products.Add(product);
    public void Remove(Product product) => Products.Remove(product);
}