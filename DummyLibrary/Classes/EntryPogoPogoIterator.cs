using DummyLibrary.Interface;

namespace DummyLibrary.Classes;

public class EntryPogoPogoIterator : IIterator<Entry>
{
    private readonly EntryCollection _entryCollection;
    private readonly HashSet<int> _traversedIndexes = new();
    private readonly Random _randomGenerator = new();
    private IList<Entry>? _entryCollectionCache;

    public EntryPogoPogoIterator(EntryCollection entryCollection)
    {
        _entryCollection = entryCollection;
    }

    public bool HasNext()
    {
        LazyInit();
        return _entryCollectionCache!.Any(e => !e.Traversed);
    }

    public Entry GetNext()
    {
        var randomIndex = GetSecureRandomIndex();
        var entry = _entryCollectionCache!.First(e => e.Position == randomIndex);
        entry.Traversed = true;
        _traversedIndexes.Add(randomIndex);

        return entry;
    }

    private int GetSecureRandomIndex()
    {
        int secureRandomIndex;
        while (true)
        {
            secureRandomIndex = _randomGenerator.Next(maxValue: _entryCollectionCache!.Count, minValue: 0);
            if (_traversedIndexes.Contains(secureRandomIndex))
            {
                continue;
            }

            break;
        }

        return secureRandomIndex;
    }

    private void LazyInit() => _entryCollectionCache ??= _entryCollection.GetEntryCollection();
}