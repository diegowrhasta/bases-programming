using DummyLibrary.Classes.Payloads;

namespace DummyLibrary.Classes;

public class EmployeeDeductionsDataViewModel : DataViewModel
{
    public DeductionsPayload Payload { get; set; } = new();
    public bool Good { get; set; } = true;

    public void DoLogic()
    {
        var separator = new string('-', 64);
        Console.WriteLine("Deductions View Model");
        Console.WriteLine(separator);
        Mediator!.Send(MediatorEvent.DeductionsRequest);
        Console.WriteLine($"General Good? {Payload.GeneralGood}");
    }
}