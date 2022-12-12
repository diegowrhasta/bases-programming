namespace DummyLibrary;

public class Tag : ICloneable<Tag>
{
    public string TagName { get; set; } = string.Empty;

    public Tag DeepClone() => (Tag)MemberwiseClone();
}