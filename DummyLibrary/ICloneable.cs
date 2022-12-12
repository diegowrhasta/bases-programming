namespace DummyLibrary;

public interface ICloneable<out T>
{
    T DeepClone();
}