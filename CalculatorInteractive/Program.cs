using System;

namespace CalculatorInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, result;
            string op;
            int opCount = 0;

            string input;

            while (true)
            {
                // ask user for operation
                Console.Write("Op: ");
                input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                op = input;

                // check if operation exists
                if (!IsValidOp(op))
                {
                    Console.WriteLine("Unknown operation, please try again");
                    continue;
                }

                // ask user for first number
                Console.Write("First number: ");
                input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                a = double.Parse(input);

                // ask user for second number
                Console.Write("Second number: ");
                input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                b = double.Parse(input);

                // find and print result based on selected operation
                switch (op)
                {
                    case "+":
                        result = Add(a, b);
                        Console.WriteLine(result);
                        opCount++;
                        break;
                    case "-":
                        result = Subtract(a, b);
                        Console.WriteLine(result);
                        opCount++;
                        break;
                    case "/":
                        result = Divide(a, b);
                        Console.WriteLine(result);
                        opCount++;
                        break;
                    case "x":
                        result = Multiply(a, b);
                        Console.WriteLine(result);
                        opCount++;
                        break;
                    case "p":
                        result = Power(a, b);
                        Console.WriteLine(result);
                        opCount++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Finished! Operations done: {opCount}");
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
