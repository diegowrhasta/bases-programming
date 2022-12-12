namespace DummyLibrary;

public class Tag : ICloneable<Tag>
{
    public string TagName { get; set; } = string.Empty;

    public Tag DeepClone()
    {
        var clone = (Tag)MemberwiseClone();

        return clone;
    }
}