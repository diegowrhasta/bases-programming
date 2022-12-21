using DummyLibrary.Classes;

namespace DummyLibrary.Interfaces;

public interface IChainHandler
{
    object? Handle(ChainHandlerRequest chainHandlerRequest);
    void SetNextHandler(IChainHandler nextHandler);
}