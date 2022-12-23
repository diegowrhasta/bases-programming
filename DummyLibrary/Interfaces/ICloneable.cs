namespace DummyLibrary.Interfaces;

public interface ICloneable<out T>
{
    T DeepClone();
}