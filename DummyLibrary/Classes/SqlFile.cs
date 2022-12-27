namespace DummyLibrary.Classes;

public class SqlFile
{
    public string FilePath { get; set; } = string.Empty;
    public string FileText { get; set; } = string.Empty;

    public void LoadText()
    {
        // Code to read from sql file
    }

    public string SaveText()
    {
        // Code to save text into sql file
        return "Saved";
    }
}