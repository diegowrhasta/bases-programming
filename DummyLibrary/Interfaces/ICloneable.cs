namespace DummyLibrary.Interfaces;

public interface ICloneable<out T> where T : class
{
    T DeepClone();
}