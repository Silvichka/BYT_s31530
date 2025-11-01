namespace ConsoleApp1.Calculator;

public class Calculator
{
    private double A { get; }
    private double B { get; }
    private char Operation { get; }

    public Calculator(double a, double b, char operation)
    {
        A = a;
        B = b;
        Operation = operation;
    }

    public double Calculate()
    {
        return Operation switch
        {
            '+' => A + B,
            '-' => A - B,
            '*' => A * B,
            '/' => B != 0 ? A / B : throw new DivideByZeroException("Cannot divide by zero."),
            _   => throw new ArgumentException("Invalid operation. Use +, -, *, or /."),
        };
    }
}