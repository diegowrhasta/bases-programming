using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

/*
 * Inherit only contracts, not concretions (never inherit from actual classes), only interfaces, abstract classes,
 * types.
 * We use composition and delegation to implement inheritance.
 * Delegation (inheritance) is when we abstract some common behavior in a superclass, and inherit that in subclasses
 * Composition is when one class does work for two or more classes, we compose this new class in the other classes
 * and delegate functionality there.
 */
public abstract class Licker : ILicker
{
    public abstract void Lick();

    public virtual void Talk()
    {
        Console.WriteLine($"{GetType().Name} is Talking.");
    }
}