namespace DummyLibrary;

public class RoundHole
{
    public float Radius { get; set; }

    public bool Fits(RoundPeg peg) => Radius >= peg.Radius;
}