using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class ReadOnlySqlFile : File, IReadableSqlFile
{
    protected override string FilePath { get; set; } = string.Empty;
    protected override string FileText { get; set; } = "Read Only, Brother";

    public string LoadText() => FileText;
}