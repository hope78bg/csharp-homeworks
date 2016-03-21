using System;

namespace PrimeChecker
{
    public class MainClass
    {
        public static bool IsPrime(ulong n)
        {
            ulong m = (ulong)Math.Floor(Math.Sqrt(n));

            for (ulong i = 2; i <= m; ++i)
            {
                if (n % i == 0)
                    return false;
            }
            return true;

        }

        public static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            Console.WriteLine("{0}", IsPrime(n));
        }
    }
}
