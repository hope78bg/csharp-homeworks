﻿using System;


class Trapezoids
{
    public static void Main()
    {
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("h=");
        double h = double.Parse(Console.ReadLine());
        double area = (((a + b) / 2) * h);
        Console.WriteLine("area = {0}",area);
    }
}

