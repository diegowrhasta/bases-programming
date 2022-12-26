using DummyLibrary.Interface;

namespace DummyLibrary.Classes;

public class Visitor : IVisitor
{
    private int _amountOfVisits;

    public void DoWithCity(City city)
    {
        Console.WriteLine("Visiting a city");
        city.Tax();
        _amountOfVisits++;
    }

    public void DoWithState(State state)
    {
        Console.WriteLine("Visiting a State");
        state.BuildNewMacdonald();
        _amountOfVisits++;
    }

    public void DoWithCountry(Country country)
    {
        Console.WriteLine("Visiting a country");
        country.HaveAnAnniversary();
        _amountOfVisits++;
    }

    public void ReportOnVisits() => Console.WriteLine($"Visitor has visited {_amountOfVisits} nodes so far!");
}