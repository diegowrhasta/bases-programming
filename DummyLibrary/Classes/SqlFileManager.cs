using System.Text;
using DummyLibrary.Interfaces;

namespace DummyLibrary.Classes;

public class SqlFileManager
{
    public IList<IWritableSqlFile> SqlFiles { get; set; } = new List<IWritableSqlFile>();
    public IList<IReadableSqlFile> ReadOnlySqlFiles { get; set; } = new List<IReadableSqlFile>();

    public string GetTextFromFiles()
    {
        var stringBuilder = new StringBuilder();
        foreach (var sqlFile in ReadOnlySqlFiles)
        {
            stringBuilder.Append(sqlFile.LoadText());
        }

        return stringBuilder.ToString();
    }

    public void SaveTextIntoFiles(string text)
    {
        foreach (var sqlFile in SqlFiles)
        {
            sqlFile.SaveText(text);
        }
    }
}