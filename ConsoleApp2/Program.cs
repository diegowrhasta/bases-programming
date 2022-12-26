// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;

const int a = 1;
const int b = 3;

var calculator = new Calculator(new SumStrategy());
var result = calculator.ExecuteCalculation(a, b);
Console.WriteLine($"The result of the calculation is: {result}");

calculator.ChangeStrategy(new SubtractStrategy());
result = calculator.ExecuteCalculation(a, b);
Console.WriteLine($"The result of the calculation is: {result}");

calculator.ChangeStrategy(new MultiplyStrategy());
result = calculator.ExecuteCalculation(a, b);
Console.WriteLine($"The result of the calculation is: {result}");

calculator.ChangeStrategy(new DivisionStrategy());
result = calculator.ExecuteCalculation(a, b);
Console.WriteLine($"The result of the calculation is: {result}");