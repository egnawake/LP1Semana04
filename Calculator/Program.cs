using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, result;
            char op;

            // validate number of arguments
            if (args.Length != 3)
            {
                Console.WriteLine($"Expected 3 arguments, got {args.Length}");
                return;
            }

            // parse arguments
            op = char.Parse(args[0]);
            a = double.Parse(args[1]);
            b = double.Parse(args[2]);

            // get result based on selected operation
            // if operation is invalid, show error and return
            switch (op)
            {
                case '+':
                    result = Add(a, b);
                    break;
                case '-':
                    result = Subtract(a, b);
                    break;
                case '/':
                    result = Divide(a, b);
                    break;
                case 'x':
                    result = Multiply(a, b);
                    break;
                case 'p':
                    result = Power(a, b);
                    break;
                default:
                    Console.WriteLine("Unknown operation");
                    return;
            }

            // print result
            Console.WriteLine(result);
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
