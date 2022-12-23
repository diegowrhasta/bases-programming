using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public abstract class DataViewModel
{
    protected IMediator? Mediator;

    protected DataViewModel(IMediator? mediator = null)
    {
        Mediator = mediator;
    }

    public void SetMediator(IMediator mediator) => Mediator = mediator;
}