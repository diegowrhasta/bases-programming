using AutoMapper;
using DummyLibraryMediatorTests.Lightweights;
using DummyLibraryMediatorTests.Models;

namespace DummyLibraryMediatorTests;

public class MapperTests
{
    [Fact]
    public void DummyObject_SelfMap_ShouldSucceed()
    {
        var mapper = new Mapper(TestingMapperConfiguration.Config);
        var dummy = new DummyObject
        {
            Name = "Diego",
            PageNumber = 24,
            Price = 33,
        };
        var emptyDummy = new DummyObject();
        emptyDummy = mapper.Map<DummyObject>(dummy);
        Assert.Equal(dummy.Name, emptyDummy.Name);
        Assert.Equal(dummy.PageNumber, emptyDummy.PageNumber);
        Assert.Equal(dummy.Price, emptyDummy.Price);
    }
}