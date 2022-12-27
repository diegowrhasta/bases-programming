using DummyLibrary.Interface;

namespace DummyLibrary.Classes;

public class Manager : ILead
{
    public void CreateSubTask()
    {
        // Manager creates Task
    }

    public void AssignTask()
    {
        // Manager assigns Task
    }

    public void WorkOnTask()
    {
        throw new Exception("Manager can't work on Task");
    }
}