namespace DummyLibrary.Classes;

public class MobAi : GameAi
{
    public MobAi()
    {
        Warriors = 100;
    }

    protected override void CollectResources()
    {
        // Do nothing
    }

    protected override void BuildStructures()
    {
        // Do nothing
    }

    protected override void BuildUnits()
    {
        // Do nothing
    }

    protected override void Attack() => Console.WriteLine($"Mobs are huge, a raid has been started, sending {Warriors}.");
}