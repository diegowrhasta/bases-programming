namespace DummyLibrary.Classes;

public abstract class GameAi
{
    protected int Resources { get; set; }
    protected int Structures { get; set; }
    protected int Warriors { get; set; }
    protected int Scouts { get; set; }

    public void TakeTurn()
    {
        CollectResources();
        BuildStructures();
        BuildUnits();
        Taunt();
        Attack();
    }

    protected abstract void CollectResources();
    protected abstract void BuildStructures();
    protected abstract void BuildUnits();
    protected abstract void Attack();

    protected virtual void SendWarriors(int position)
    {
        if (Warriors <= 0)
        {
            return;
        }

        Console.WriteLine($"Sending Warriors to square {position} - {GetType().Name}");
    }

    protected virtual void SendScouts(int position)
    {
        if (Scouts <= 0)
        {
            return;
        }

        Console.WriteLine($"Sending Scouts to square {position} - {GetType().Name}");
    }

    protected virtual void Taunt()
    {
        // Hook for if Ai taunts.
    }
}