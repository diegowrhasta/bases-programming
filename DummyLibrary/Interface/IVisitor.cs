using DummyLibrary.Classes;

namespace DummyLibrary.Interface;

public interface IVisitor
{
    void DoWithCity(City city);
    void DoWithState(State state);
    void DoWithCountry(Country country);
}