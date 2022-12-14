namespace DummyLibrary;

public class TreeType
{
    public string Name { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public string Texture { get; set; } = string.Empty;

    public override string ToString() => $"Name: {Name}\n" +
                                         $"Color: {Color}\n" +
                                         $"Texture: {Texture}";
}