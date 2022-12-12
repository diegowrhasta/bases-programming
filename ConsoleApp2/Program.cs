// See https://aka.ms/new-console-template for more information

using DummyLibrary;

var book1 = new Book
{
    Name = "Hello",
    Tag = new Tag { TagName = "Tag 1" },
};

var book1Copy = book1.DeepClone();
Console.WriteLine($"Name: {book1.Name}");
Console.WriteLine($"Name: {book1Copy.Name}");
Console.WriteLine($"Name: {book1.Tag.TagName}");
Console.WriteLine($"Name: {book1Copy.Tag.TagName}");
book1Copy.Name = "BRAH";
book1Copy.Tag.TagName = "TAGAGAGAG";
Console.WriteLine($"Name: {book1.Name}");
Console.WriteLine($"Name: {book1Copy.Name}");
Console.WriteLine($"Name: {book1.Tag.TagName}");
Console.WriteLine($"Name: {book1Copy.Tag.TagName}");