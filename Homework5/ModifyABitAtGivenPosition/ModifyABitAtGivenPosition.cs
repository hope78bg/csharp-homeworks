using System;


class ModifyABitAtGivenPosition
{
    public static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p=");
        int p = int.Parse(Console.ReadLine());
        Console.Write("v=");
        int v = int.Parse(Console.ReadLine());
        int result;
        if (v == 0)
        {
            int mask = ~(1 << p);
            result = mask & n;
        }
        else
        {
            int mask = 1 << p;
            result = mask | n;
        }
        Console.WriteLine(result);   
    }
}

