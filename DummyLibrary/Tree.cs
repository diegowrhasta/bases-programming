namespace DummyLibrary;

public class Tree
{
    public float X { get; set; }
    public float Y { get; set; }
    public TreeType TreeType { get; set; } = new();

    public override string ToString() => $"{TreeType}\n" +
                                         $"X: {X}\n" +
                                         $"Y: {Y}";
}