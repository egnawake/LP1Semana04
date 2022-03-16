using System;

namespace MyFirstMethod
{
    /// <summary>
    /// Main class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Program entry point.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        static void Main(string[] args)
        {
            CountToN(7);
            Console.WriteLine("");
            CountToN(13);
            Console.WriteLine("");
            CountToN(5, 16);
        }

        /// <summary>
        /// Prints integers from 1 to 10.
        /// </summary>
        private static void CountTo10()
        {
            CountToN(10);
        }

        /// <summary>
        /// Prints integers from 1 to n.
        /// </summary>
        /// <param name="n">Last integer to be printed.</param>
        private static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Prints integers from n1 to n2.
        /// </summary>
        /// <param name="n1">First integer to be printed.</param>
        /// <param name="n2">Last integer to be printed.</param>
        private static void CountToN(int n1, int n2)
        {
            for (int i = n1; i <= n2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
