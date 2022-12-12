namespace DummyLibrary;

public class Book : ICloneable<Book>
{
    public string Name { get; set; } = string.Empty;
    public int Reference { get; set; }
    public bool IsOld { get; set; }
    public IEnumerable<Author> Authors { get; set; } = new List<Author> { new() { Name = "Big", Age = 20, } };
    public IEnumerable<string> PeopleThatRead { get; set; } = new List<string> { "Diego", "Lindsay" };
    public Tag Tag { get; set; } = new();

    public Book DeepClone()
    {
        var clone = (Book)MemberwiseClone();
        clone.Tag = Tag.DeepClone();
        clone.Authors = Authors.DeepClone();

        return clone;
    }
}