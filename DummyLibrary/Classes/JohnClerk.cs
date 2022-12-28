using DummyLibrary.Interface;

namespace DummyLibrary.Classes;

public class JohnClerk : IClerk
{
    public string AnswerQuestion(string question)
    {
        Console.WriteLine($"John answers the question: {question}");

        return "No";
    }

    public void ScanProduct(string product)
    {
        Console.WriteLine($"John scans the product: {product}");
    }

    public void BagProduct(string product)
    {
        Console.WriteLine($"John bags the product: {product}");
    }

    public void PromptForPayment(string customer)
    {
        Console.WriteLine($"John prompts {customer} for the payment.");
    }
}