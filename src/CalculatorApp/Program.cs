using CalculatorApp;

// Entry point of the console app.
// It only reads input and prints output; the real logic lives in Calculator.cs.
var calculator = new Calculator();

Console.WriteLine("Simple Calculator");
Console.WriteLine("-----------------");

Console.Write("Enter first number: ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Enter second number: ");
int b = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine();
Console.WriteLine($"{a} + {b} = {calculator.Add(a, b)}");
Console.WriteLine($"{a} - {b} = {calculator.Subtract(a, b)}");
Console.WriteLine($"{a} * {b} = {calculator.Multiply(a, b)}");

try
{
    Console.WriteLine($"{a} / {b} = {calculator.Divide(a, b)}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"{a} / {b} = {ex.Message}");
}
