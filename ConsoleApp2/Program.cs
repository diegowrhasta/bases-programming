// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;

var sqlFiles = new List<SqlFile>
{
    new() { FilePath = "./", FileText = "Hello", },
    new() { FilePath = "./1", FileText = "Hello 2", },
    new() { FilePath = "./2", FileText = "Hello 3", },
};

var fileManager = new SqlFileManager();
fileManager.SqlFiles = sqlFiles;
var text = fileManager.GetTextFromFiles(); 
Console.WriteLine("All Text");
Console.WriteLine(text);
