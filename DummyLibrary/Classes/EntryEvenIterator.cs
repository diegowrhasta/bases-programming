using DummyLibrary.Interface;

namespace DummyLibrary.Classes;

public class EntryEvenIterator : IIterator<Entry>
{
    private readonly IEntryCollection _entryCollection;
    private IList<Entry>? _entryCache;
    private int _counter;

    public EntryEvenIterator(IEntryCollection entryCollection)
    {
        _entryCollection = entryCollection;
    }

    public bool HasNext()
    {
        LazyInit();
        return _counter < _entryCache!.Count;
    }

    public Entry GetNext()
    {
        var entry = _entryCache!.ElementAt(_counter);
        _counter += 2;

        return entry;
    }

    private void LazyInit() => _entryCache ??= _entryCollection.GetEntryCollection();
}