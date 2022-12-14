using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class SmallBox : Product
{
    public SmallBox(Product product)
    {
        Product = product;
    }

    internal override string ProductName { get; set; } = "Small Box";
    public override double TaxRate { get; set; } = 1.10d;
    public override double UnitCost { get; set; } = 15;
    public Product Product { get; set; }

    public override double CalculatePrice()
    {
        var boxPrice = base.CalculatePrice();
        var productPrice = Product.CalculatePrice();

        return productPrice + boxPrice;
    }
}