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
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
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
