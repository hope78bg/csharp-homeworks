using System;

class OddOrEvenIntegers
{
    public static void Main()
    {
        Console.Write("a=");
        int a = int.Parse(Console.ReadLine());
        bool odd = (a%2!=0)&&(a!=0);
        Console.WriteLine(odd);
    }
}

