namespace DummyLibrary;

public class SquarePegAdapter : RoundPeg
{
    private readonly SquarePeg _peg;

    public SquarePegAdapter(SquarePeg peg)
    {
        _peg = peg;
    }

    public override float Radius => (float)(_peg.Width * Math.Sqrt(2) / 2);
}