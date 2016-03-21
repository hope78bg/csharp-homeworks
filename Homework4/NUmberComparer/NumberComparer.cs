using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("a = ");
        string a = Console.ReadLine();
        Console.Write("b = ");
        string b = Console.ReadLine();
        int c = int.Parse(a);
        int d = int.Parse(b);
        Console.WriteLine(Math.Max(c,d));
    }
}

