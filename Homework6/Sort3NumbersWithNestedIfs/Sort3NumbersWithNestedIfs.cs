﻿using System;


class Sort3NumbersWithNestedIfs
{
    public static void Main()
    {
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double c = double.Parse(Console.ReadLine());

        if (a > b && b > c)
        {
            Console.WriteLine("result {0} {1} {2}", a, b, c);
        }
        else if (b > a && a > c)
        {
            Console.WriteLine("result {0} {1} {2}", b, a, c);
        }
        else if (c > a && a > b)
        {
            Console.WriteLine("result {0} {1} {2}", c, a, b);
        }
        else if (a > b && c > b && a > c)
        {
            Console.WriteLine("result {0} {1} {2}", a, c, b);
        }
        else if (a == b && a < c)
        {
            Console.WriteLine("result {0} {1} {2}", c, a, b);
        }
            else if (a==b && a>c)
            {
                Console.WriteLine("result {0} {1} {2}", a, b,c);
            }
        else if (a <b && b==c)
        {
            Console.WriteLine("result {0} {1} {2}", b, c, a);
         }
        else if (a > b && b == c)
        {
            Console.WriteLine("result {0} {1} {2}",a, b, c);
        }
        else if (a < b && b > c && c > a)
        {
            Console.WriteLine("result {0} {1} {2}", b, c, a);
        }
            

    }
}

