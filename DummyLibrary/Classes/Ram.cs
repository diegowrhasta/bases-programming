using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class Ram : Product
{
    internal override string ProductName { get; set; } = "RAM";
    public override double TaxRate { get; set; } = 1.15d;
    public override double UnitCost { get; set; } = 95d;
}