using DummyLibrary.Classes;

namespace DummyLibrary.Repository;

public static  class EntryRepository
{
    private static readonly IList<Entry> Entries = new List<Entry>
    {
        new() { Name = "Diego", Position = 0},
        new() { Name = "Clark", Position = 1},
        new() { Name = "Herrscher", Position = 2},
        new() { Name = "Dude", Position = 3 },
        new() { Name = "Faceless", Position = 4 },
        new() { Name = "Mirana", Position = 5 },
        new() { Name = "Bro", Position = 6 },
        new() { Name = "Yes", Position = 7 },
    };

    public static IList<Entry> GetEntries() => Entries;
}