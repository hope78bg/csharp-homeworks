using System;

class PointInACircle
{
    //the expression is: 4 >= x * x + y * y
    public static void Main()
    {
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine(4 >= x * x + y * y);
    }
}