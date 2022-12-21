using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public abstract class ChainHandler : IChainHandler
{
    private IChainHandler? _nextHandler;

    public virtual object? Handle(ChainHandlerRequest chainHandlerRequest) => _nextHandler?.Handle(chainHandlerRequest);

    public void SetNextHandler(IChainHandler nextHandler) =>  _nextHandler = nextHandler;
}