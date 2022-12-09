namespace DummyLibrary.Interfaces;

public interface ICoffeeTable
{
    public bool IsSquare { get; set; }
    public bool IsLong { get; set; }
    public void SitOn();
}