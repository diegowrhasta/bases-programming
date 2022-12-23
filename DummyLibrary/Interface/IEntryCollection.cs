using DummyLibrary.Classes;
using DummyLibrary.Repository;

namespace DummyLibrary.Interface;

public interface IEntryCollection
{
    IIterator<Entry> GetPogoPogoIterator();

    IIterator<Entry> GetEvenIterator();

    IList<Entry> GetEntryCollection();
}