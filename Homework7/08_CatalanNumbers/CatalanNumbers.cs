using System;
using System.Numerics;


class CatalanNumbers
{
    public static void Main()
    {
        Console.Write("Pleace,enter number n=");
        uint n = uint.Parse(Console.ReadLine());

        BigInteger nominator = 1;
        BigInteger denominator = 1;
        if ((n > 1) && (n < 100))
        {
            for (int k = 2; k <= n; ++k)
            {
                nominator *= n + k;
                denominator *= k;
            }
            Console.WriteLine(nominator / denominator);
        }
        else
        {
            Console.WriteLine("Enter 1 < n < 100");
        }            
    }
}
