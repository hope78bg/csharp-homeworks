using System;
class PointInsidedeACircleOutsideOfARectangle
{
    public static void Main()
    {
        Console.Write("x=");
        double x = double.Parse(Console.ReadLine()); 
        Console.Write("y=");
        double y = double.Parse(Console.ReadLine());
        bool isInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= (1.5 * 1.5);
        bool isOutsideRectangle = (x < -1) || (x > 5) || (y < -1) || (y > 1);
        Console.WriteLine((isInCircle && isOutsideRectangle) ? "yes" : "no");
    }
}

