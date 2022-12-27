namespace DummyLibrary.Classes;

public class DataExporter
{
    public void ExportDataFromFile()
    {
        try
        {
            // Code to export data from file to database.
        }
        catch (Exception e)
        {
            new ExceptionLogger().LogIntoFile(e);
        }
    }
}