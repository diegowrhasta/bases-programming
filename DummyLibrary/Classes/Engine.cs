namespace DummyLibrary.Classes;

public class Engine
{
    public float Displacement { get; set; }

    // This is always in HP (Horse Power)
    public int PowerOutput { get; set; }
    public string BoreAndStroke { get; set; } = string.Empty;

    // This is always in Kg
    public int Weight { get; set; }
    public string Type { get; set; } = string.Empty;
}