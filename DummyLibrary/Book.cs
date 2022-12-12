namespace DummyLibrary;

public class Book : ICloneable<Book>
{
    public string Name { get; set; } = string.Empty;
    public int Reference { get; set; }
    public bool IsOld { get; set; }
    public Tag Tag { get; set; } = new();

    public Book DeepClone()
    {
        var clone = (Book)MemberwiseClone();
        clone.Tag = Tag.DeepClone();

        return clone;
    }
}