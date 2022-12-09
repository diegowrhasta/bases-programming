namespace DummyLibrary.Interfaces;

public interface IProduct
{
    public bool IsSquare { get; set; }
    public bool IsLong { get; set; }
    public void SitOn();
}