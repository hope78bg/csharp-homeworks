using System;


class RandomNumbersInGivenRange
{
    public static void Main(string[] args)
    {
        Console.Write("Enret your number n=");
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        for (int i = 0; i < n; ++i)
        {
            Console.Write("{0} ", rnd.Next(min, max + 1));
        }

        Console.WriteLine();
    }
}

