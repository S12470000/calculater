using System;

class Calculator
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Simple Calculator with Exception Handling");

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Operation input
            Console.Write("Enter operation (+, -, *, /): ");
            string op = Console.ReadLine();

            // Result calculation
            double result = Calculate(num1, num2, op);

            Console.WriteLine($"Result: {result}");
        }
        catch (FormatException)
        { 
            Console.WriteLine("Invalid input! Please enter numeric values.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error! Cannot divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }

    // Function for calculation
    static double Calculate(double a, double b, string operation)
    {
        switch (operation)
        {
            case "+":
                return Add(a, b);
            case "-":
                return Subtract(a, b);
            case "*":
                return Multiply(a, b);
            case "/":
                return Divide(a, b);
            default:
                throw new ArgumentException("Invalid operation");
        }
    }

    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException();
        return a / b;
    }
}
