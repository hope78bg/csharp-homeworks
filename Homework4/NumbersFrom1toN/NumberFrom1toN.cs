using System;


class NumbersFrom1toN
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer=  ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; ++i)
        {

            Console.WriteLine("{0}",i);
        }

    }
}

