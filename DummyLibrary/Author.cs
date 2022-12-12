namespace DummyLibrary;

public class Author : ICloneable<Author>
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }

    public Author DeepClone() => (Author)MemberwiseClone();
}