namespace DummyLibrary.Interface;

public interface IIterator<out T>
{
    bool HasNext();
    T GetNext();
}