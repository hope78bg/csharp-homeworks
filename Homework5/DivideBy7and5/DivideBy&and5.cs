using System;

class DivideBy7and5
{
    public static void Main()
    {
        Console.Write("a=");
        int a = int.Parse(Console.ReadLine());
        bool divide = (a % 35 == 0);
        Console.WriteLine(divide);
    }
}

