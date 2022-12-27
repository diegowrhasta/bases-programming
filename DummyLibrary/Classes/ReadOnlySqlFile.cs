namespace DummyLibrary.Classes;

public class ReadOnlySqlFile : SqlFile
{
    public new void SaveText()
    {
        throw new IOException("Can't Save");
    }
}