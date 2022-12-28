using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class OrcExploder : IExploder
{
    public void ExplodeEntities()
    {
        // Here goes a really messed up and big process that only the designer 
        // and the class itself knows about. Deals with fields, deals with private functions
        // deals with other services. But the one consuming the class, (through an interface),
        // doesn't care, he only cares that this explodes entities. (In this case Orcs).
    }
}