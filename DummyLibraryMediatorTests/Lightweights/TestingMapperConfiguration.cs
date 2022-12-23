using AutoMapper;
using DummyLibraryMediatorTests.Models;

namespace DummyLibraryMediatorTests.Lightweights;

public static class TestingMapperConfiguration
{
    public static readonly MapperConfiguration Config =
        new(cfg =>
        {
            cfg.CreateMap<DummyObject, DummyObject>();
        });
}