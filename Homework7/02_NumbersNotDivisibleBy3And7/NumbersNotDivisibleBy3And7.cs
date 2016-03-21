using System;

class NumbersNotDivisibleBy3And7
{
    public static void Main()
    {
        Console.Write("Enter your number n = ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if ((i % 3 == 0) || (i % 7 == 0))
            {
                continue;
            }
        
            Console.Write(i+ " ");
        }
    }
}

