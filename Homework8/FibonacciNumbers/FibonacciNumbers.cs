using System;

namespace FibonacciNumbers
{
    class MainClass
    {
        private static ulong Fib(ulong n)
        {
            ulong a = 0;
            ulong b = 1;
            ulong c = a + b;
            for (ulong i = 1; i < n; ++i)
            {
                a = b;
                b = c;
                c = a + b;
            }
            return c;
        }

        public static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            Console.WriteLine("{0}", Fib(n));
        }
    }
}
