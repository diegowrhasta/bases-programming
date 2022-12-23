using DummyLibrary.Classes;
using DummyLibrary.Interface;
using DummyLibrary.Repository;
using Moq;

namespace DummyLibraryTestsIterator;

public class IteratorTests
{
    [Fact]
    public void PogoPogo_Iterator_ShouldSucceed()
    {
        var mockedCollection = new Mock<IEntryCollection>();
        mockedCollection.Setup(p => p.GetEntryCollection()).Returns(EntryRepository.GetEntries);
        mockedCollection.Setup(p => p.GetPogoPogoIterator()).Returns(new EntryPogoPogoIterator(mockedCollection.Object));
        var iterator = mockedCollection.Object.GetPogoPogoIterator();
        var entryIteration = new List<Entry>();
        while (iterator.HasNext())
        {
            entryIteration.Add(iterator.GetNext());
        }

        Assert.Equal(8, entryIteration.Count);
    }

    [Fact]
    public void Even_Iterator_ShouldSucceed()
    {
        var mockedCollection = new Mock<IEntryCollection>();
        mockedCollection.Setup(p => p.GetEntryCollection()).Returns(EntryRepository.GetEntries);
        mockedCollection.Setup(p => p.GetEvenIterator()).Returns(new EntryEvenIterator(mockedCollection.Object));
        var iterator = mockedCollection.Object.GetEvenIterator();
        var entryIteration = new List<Entry>();
        while (iterator.HasNext())
        {
            entryIteration.Add(iterator.GetNext());
        }

        Assert.Equal(4, entryIteration.Count);
        Assert.Equal(0, entryIteration.ElementAt(0).Position);
        Assert.Equal(2, entryIteration.ElementAt(1).Position);
        Assert.Equal(4, entryIteration.ElementAt(2).Position);
        Assert.Equal(6, entryIteration.ElementAt(3).Position);
    }
}