using System;

class GravitationOnTheMoon
{
    public static void Main()
    {
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        double b = a * 0.17;
        Console.WriteLine("weight ot the Moon = {0:F3}",b);
    }
}

