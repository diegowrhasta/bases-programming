using DummyLibrary.Classes;

namespace DummyLibrary.Interfaces;

public interface IMediator
{
    void Send(MediatorEvent @event);
}