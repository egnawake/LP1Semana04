using System;

namespace CalculatorInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, result;
            string op;

            while (op != "END")
            {
                // ask user for arguments
                Console.Write("Op: ");
                op = Console.ReadLine();
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
                        break;
                    case "-":
                        result = Subtract(a, b);
                        break;
                    case "/":
                        result = Divide(a, b);
                        break;
                    case "x":
                        result = Multiply(a, b);
                        break;
                    case "p":
                        result = Power(a, b);
                        break;
                    case "END":
                        break;
                    default:
                        Console.WriteLine("Unknown operation");
                        break;
                }

                // print result
                Console.WriteLine(result);
            }
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
    }
}
