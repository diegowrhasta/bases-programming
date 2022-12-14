using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class GraphicsCard : Product
{
    internal override string ProductName { get; set; } = "GPU";
    public override double TaxRate { get; set; } = 1.45d;
    public override double UnitCost { get; set; } = 1000d;
}