using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci(int.Parse(Console.ReadLine()));
        }

        private static void Fibonacci(int n)
        {
            int x = 1;
            int y = 0;

            for (int i = 0; i < n; i++)
            {
                int z = x + y;
                Console.WriteLine(z);

                y = x;
                x = z;
            }
        }
    }
}