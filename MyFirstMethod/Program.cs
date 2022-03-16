using System;

namespace MyFirstMethod
{
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
    }
}
