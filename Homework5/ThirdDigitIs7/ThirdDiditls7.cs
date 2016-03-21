using System;

class ThirdDigitIs7
{
    public static void Main()
    {
        Console.Write("a=");
        int a = int.Parse(Console.ReadLine());
        a = a / 100;

        Console.WriteLine(a % 10 == 7);
    }
}

