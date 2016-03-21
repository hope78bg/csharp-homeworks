using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("r= ");
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * r;
        Console.WriteLine("perimeter = {0:F2}", perimeter);
        double area = Math.PI * r * r;
        Console.WriteLine("surface = {0:F2}", area);

    }
}

