using System;

namespace MyFirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CountToN(7);
            Console.WriteLine("");
            CountToN(13);
        }

        private static void CountTo10()
        {
            CountToN(10);
        }

        private static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
