using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class SqlFile : File, IReadableSqlFile, IWritableSqlFile
{
    protected override string FilePath { get; set; } = string.Empty;
    protected override string FileText { get; set; } = string.Empty;

    public string LoadText() => FileText;

    public void SaveText(string text) => FileText = text;
}