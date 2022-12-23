using DummyLibrary.Interface;
using DummyLibrary.Repository;

namespace DummyLibrary.Classes;

public class EntryCollection : ICoolCollection<Entry>, IEntryCollection
{
    public IIterator<Entry> GetPogoPogoIterator() => new EntryPogoPogoIterator(this);

    public IIterator<Entry> GetEvenIterator() => new EntryEvenIterator(this);

    public IList<Entry> GetEntryCollection() => EntryRepository.GetEntries();
}