using AutoMapper;
using DummyLibrary.Classes.Payloads;

namespace DummyLibrary.Lightweights;

public static class DummyMapperConfiguration
{
    public static readonly MapperConfiguration Config =
        new(cfg =>
            {
                cfg.CreateMap<BenefitsPayload, BenefitsPayload>();
                cfg.CreateMap<DeductionsPayload, DeductionsPayload>();
                cfg.CreateMap<GeneralPayload, GeneralPayload>();
                cfg.CreateMap<FinancialPayload, FinancialPayload>();
            });
}