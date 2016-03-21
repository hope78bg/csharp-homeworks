using System;

class Rectangles
{
    public static void Main()
    {
        Console.Write(" a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write(" b= ");
        double b = double.Parse(Console.ReadLine());
        double perimeter = (2 * a) + (2 * b);
        double area = (a * b);
        Console.WriteLine(" Perimeter= {0}  Area ={1}", perimeter, area);

    }
}

