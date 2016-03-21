using System;


class CheckABitAtGivenPosition
{
    public static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p=");
        int p = int.Parse(Console.ReadLine());
        int nRightP = n >> p;
        int P = nRightP & 1;
        Console.WriteLine(P == 1);
    }
}

