using System;


class TheBiggestOfFiveNumbers
{
    public static void Main()
    {
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d=");
        double d = double.Parse(Console.ReadLine());
        Console.Write("f=");
        double f = double.Parse(Console.ReadLine());
        if (a > b && a > c && a > d && a > f)
        {
            Console.WriteLine("biggest is {0}", a);
        }
            else if (b>a && b>c && b>d && b>f)
            {
                Console.WriteLine ("biggest is {0}",b);
            }
            else if (c>a && c>b && c>d && c>f)
            {
                Console.WriteLine ("biggest is {0}",c);
            }
            else if (d>a && d>b && d>c && d>f)
            {
                Console.WriteLine ("biggest is {0}",d);
            }
            else
            {                       
            Console.WriteLine ("biggest is {0}",f);
            }



    }
}

