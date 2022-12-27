namespace DummyLibrary.Classes;

public abstract class File
{
    protected abstract string FilePath { get; set; }
    protected abstract string FileText { get; set; }
}