using DummyLibrary.Classes.Payloads;

namespace DummyLibrary.Classes;

public class EmployeeGeneralDataViewModel : DataViewModel
{
    public int Views { get; set; }
    public bool Good { get; set; } = true;
    public string Title { get; set; } = "Me like eggs";
    public GeneralPayload Payload { get; set; } = new();

    public void DoLogic()
    {
        var separator = new string('-', 64);
        Console.WriteLine("General View Model");
        Console.WriteLine(separator);
        Mediator!.Send(MediatorEvent.GeneralRequest);
        Console.WriteLine($"Financial Good? {Payload.FinancialGood}");
        Console.WriteLine($"Deductions Good? {Payload.DeductionsGood}");
        Console.WriteLine($"Benefits Good? {Payload.BenefitsGood}");
    }
}