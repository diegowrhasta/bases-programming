// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;
using DummyLibrary.Interfaces;

var writeableFiles = new List<IWritableSqlFile>
{
    new SqlFile(),
    new SqlFile(),
    new SqlFile(),
};

var readOnlyFiles = new List<IReadableSqlFile>
{
    new ReadOnlySqlFile(),
    new ReadOnlySqlFile(),
    new ReadOnlySqlFile(),
};

var fileManager = new SqlFileManager
{
    SqlFiles = writeableFiles,
    ReadOnlySqlFiles = readOnlyFiles
};
fileManager.SaveTextIntoFiles("Hello People");

var text = fileManager.GetTextFromFiles();
Console.WriteLine("All Text");
Console.WriteLine(text);