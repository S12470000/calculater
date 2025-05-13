
using System;

namespace MyFirstAssignment
{
    class SimpleCalaulator
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("................... ");
                Console.WriteLine(" Calculator Program ");
                Console.WriteLine("................... ");

                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option:");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = {result}");
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Your result: {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Cannot divide by zero.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                Console.Write("Would you like to continue? (y = yes, n = no): ");
                choice = Console.ReadLine();

            } while (choice.ToUpper() == "Y");

            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}
