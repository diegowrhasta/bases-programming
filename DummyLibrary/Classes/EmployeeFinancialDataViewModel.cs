using DummyLibrary.Classes.Payloads;

namespace DummyLibrary.Classes;

public class EmployeeFinancialDataViewModel : DataViewModel
{
    public bool Good { get; set; }
    public FinancialPayload Payload { get; set; } = new();

    public void DoLogic()
    {
        var separator = new string('-', 64);
        Console.WriteLine("Financial View Model");
        Console.WriteLine(separator);
        Mediator!.Send(MediatorEvent.FinancialRequest);
        Console.WriteLine($"General: {Payload.GeneralTitle}");
        Console.WriteLine($"Benefits Total: {Payload.BenefitTotal}");
    }
}