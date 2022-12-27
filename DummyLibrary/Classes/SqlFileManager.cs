using System.Text;

namespace DummyLibrary.Classes;

public class SqlFileManager
{
    public IList<SqlFile> SqlFiles { get; set; } = new List<SqlFile>();

    public string GetTextFromFiles()
    {
        var stringBuilder = new StringBuilder();
        foreach (var sqlFile in SqlFiles)
        {
            stringBuilder.Append(sqlFile.FileText);
        }

        return stringBuilder.ToString();
    }

    public void SaveTextIntoFiles()
    {
        foreach (var sqlFile in SqlFiles)
        {
            sqlFile.SaveText();
        }
    }
}