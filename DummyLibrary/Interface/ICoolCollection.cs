namespace DummyLibrary.Interface;

public interface ICoolCollection<out T>
{
    IIterator<T> GetPogoPogoIterator();
    IIterator<T> GetEvenIterator();
}