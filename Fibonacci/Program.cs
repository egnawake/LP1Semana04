using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user for term
            Console.WriteLine("Enter a term: ");
            int term = int.Parse(Console.ReadLine());

            // print result
            int result = Fibonacci(term);
            Console.WriteLine($"Term {term}: {result}");
        }

        private static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            return Fibonacci(n - 2) + Fibonacci(n - 1);
        }
    }
}
