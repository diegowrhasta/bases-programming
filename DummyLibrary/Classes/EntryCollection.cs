using DummyLibrary.Interface;
using DummyLibrary.Repository;

namespace DummyLibrary.Classes;

public class EntryCollection : ICoolCollection<Entry>
{
    public IIterator<Entry> GetPogoPogoIterator() => new EntryPogoPogoIterator(this);

    public IIterator<Entry> GetEvenIterator()
    {
        throw new NotImplementedException();
    }

    public IList<Entry> GetEntryCollection() => EntryRepository.GetEntries();
}