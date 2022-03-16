using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int term = 1;

            // use term from command-line arguments
            // if not present, read term from user input
            if (args.Length > 0)
            {
                term = int.Parse(args[0]);
            }
            else
            {
                Console.WriteLine("Enter a term: ");
                term = int.Parse(Console.ReadLine());
            }

            // print result
            int result = Fibonacci(term);
            Console.WriteLine($"Term {term}: {result}");
        }

        /// <summary>
        /// Calculates terms from the Fibonacci sequence.
        /// </summary>
        /// <param name="n">Term to find.</param>
        /// <returns>Result for term n.</returns>
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
