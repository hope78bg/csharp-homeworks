using System;


class NumbersInInterval
{
    static void Main()
    {
        Console.Write("Start n = ");
        string input = Console.ReadLine();
        long a = long.Parse(input);
        Console.Write("End m = ");
        string output=Console.ReadLine();
        long b = long.Parse(output);
        int count = 0;
        for (long i = a; i<=b; ++i)
        {
            if (i%5==0)
            {
                count++;

            }
        }
        Console.WriteLine(count);
    }
}

