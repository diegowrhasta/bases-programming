using DummyLibrary.Interface;

namespace DummyLibrary.Classes;

public static class EntryKiller
{
    public static void KillEntries(IIterator<Entry> iterator)
    {
        while (iterator.HasNext())
        {
            var entry = iterator.GetNext();
            Console.WriteLine($"Ha! {entry.Name}. You're dead.");
        }
    }
}