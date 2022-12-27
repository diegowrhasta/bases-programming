using System.Data.SqlTypes;

namespace DummyLibrary.Classes;

public class DataExporter
{
    public void ExportDataFromFile()
    {
        ExceptionLogger exceptionLogger;
        try
        {
            // Code to export data from file to database.
        }
        catch (IOException e)
        {
            exceptionLogger = new ExceptionLogger(new DbLogger());
            exceptionLogger.LogException(e);
        }
        catch (SqlTruncateException e)
        {
            exceptionLogger = new ExceptionLogger(new EventLogger());
            exceptionLogger.LogException(e);
        }
        catch (Exception e)
        {
            exceptionLogger = new ExceptionLogger(new FileLogger());
            exceptionLogger.LogException(e);
        }
    }
}