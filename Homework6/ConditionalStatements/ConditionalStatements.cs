﻿using System;

class ConditionalStatements
{
    public static void Main()
    {
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine()); 
        if (a < b)
        {
            Console.WriteLine("result {0} {1}", a,b);
        }
        else
        {
            Console.WriteLine("result {0} {1}", b,a);
        }
    }
}

