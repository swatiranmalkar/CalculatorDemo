namespace CalculatorApp;

// The "business logic" we want to test.
// Keeping it in its own class (not inside Program.cs) is what makes it testable.
public class Calculator
{
    public int Add(int a, int b) => a + b;

    public int Subtract(int a, int b) => a - b;

    public int Multiply(int a, int b) => a * b;

    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        if(a==0)
        {
			return 0;
        }

        return a / b;
    }
}
