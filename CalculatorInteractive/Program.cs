using System;

namespace CalculatorInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, result;
            string op;

            do
            {
                // ask user for arguments
                Console.Write("Op: ");
                op = Console.ReadLine();
                if (!IsValidOp(op))
                {
                    Console.WriteLine("Unknown operation, please try again");
                    continue;
                }

                Console.Write("First number: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Second number: ");
                b = double.Parse(Console.ReadLine());

                // get result based on selected operation
                // if operation is invalid, show error and return
                switch (op)
                {
                    case "+":
                        result = Add(a, b);
                        Console.WriteLine(result);
                        break;
                    case "-":
                        result = Subtract(a, b);
                        Console.WriteLine(result);
                        break;
                    case "/":
                        result = Divide(a, b);
                        Console.WriteLine(result);
                        break;
                    case "x":
                        result = Multiply(a, b);
                        Console.WriteLine(result);
                        break;
                    case "p":
                        result = Power(a, b);
                        Console.WriteLine(result);
                        break;
                    case "END":
                        break;
                    default:
                        break;
                }
            } while (op != "END");
        }

        private static double Add(double a, double b)
        {
            return a + b;
        }

        private static double Subtract(double a, double b)
        {
            return a - b;
        }

        private static double Divide(double a, double b)
        {
            return a / b;
        }

        private static double Multiply(double a, double b)
        {
            return a * b;
        }

        private static double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        private static bool IsValidOp(string op)
        {
            return op == "+" || op == "-" || op == "/" || op == "x" || op == "p";
        }
    }
}
