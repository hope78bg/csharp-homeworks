using System;


class Bitwise
{
    public static void Main()
    {
        Console.Write("a=");
        int a = int.Parse(Console.ReadLine());
        int p = 3;
       
        int mask  = a >> p;
        int result = mask&1;
        Console.WriteLine(result);
    }
}

