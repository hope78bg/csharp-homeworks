using System;


class ExtractBitFromInteger
{
    public static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p=");
        int p = int.Parse(Console.ReadLine());
        int mask  = n >> p;
        int result = mask&1;
        Console.WriteLine(result);
    }
}

