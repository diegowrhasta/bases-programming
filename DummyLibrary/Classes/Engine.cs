using System.Text;

namespace DummyLibrary.Classes;

public class Engine
{
    // This is always in L (Liters)
    public float Displacement { get; set; }

    // This is always in HP (Horse Power)
    public int PowerOutput { get; set; }
    public string BoreAndStroke { get; set; } = string.Empty;

    // This is always in Kg
    public int Weight { get; set; }
    public string Type { get; set; } = string.Empty;

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append($"Displacement: {Displacement} l\n");
        stringBuilder.Append($"Power Output: {PowerOutput} HP\n");
        stringBuilder.Append($"Bore & Stroke: {BoreAndStroke}\n");
        stringBuilder.Append($"Weight: {Weight} kg");

        return stringBuilder.ToString();
    }
}