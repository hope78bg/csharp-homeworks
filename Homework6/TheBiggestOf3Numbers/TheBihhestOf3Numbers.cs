﻿using System;


class TheBiggestOf3Numbers
{
    public static void Main()
    {
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double c = double.Parse(Console.ReadLine());
        if (a >= b && a >= c)
        {
            Console.WriteLine("biggest {0}", a); 
        }
        else if ( b>=a && b >=c)
        {
            Console.WriteLine("biggest {0}", b);
        }
        else 
        {
            Console.WriteLine("biggest {0}", c);
        }
    }
}

