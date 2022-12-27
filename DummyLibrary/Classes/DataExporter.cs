namespace DummyLibrary.Classes;

public class DataExporter
{
    public void ExportDataFromFile()
    {
        try
        {
            // Code to export data from file to database.
        }
        catch (IOException e)
        {
            new ExceptionLogger().LogIntoDataBase(e);
        }
        catch (Exception e)
        {
            new ExceptionLogger().LogIntoFile(e);
        }
    }
}