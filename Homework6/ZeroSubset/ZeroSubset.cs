using System;


class ZeroSubset
{
    public static void Main(string[] args)
    {
        Console.Write("a=");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b=");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c=");
        int c = int.Parse(Console.ReadLine());
        Console.Write("d=");
        int d = int.Parse(Console.ReadLine());
        Console.Write("f=");
        int f = int.Parse(Console.ReadLine());

        if (a == 0 && b == 0 && c == 0 && d == 0 && f == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3}+{4}=0", a, b, c, d, f);
        }
        else
        {
            if (a + b == 0)
            {
            
                Console.WriteLine("{0}+{1}=0", a, b);
            }
            if (a + c == 0)
            {
                Console.WriteLine("{0}+{1}=0", a, c);
            }
            if (a + d == 0)
            {
                Console.WriteLine("{0}+{1}=0", a, d);
            }
            if (a + f == 0)
            {
                Console.WriteLine("{0}+{1}=0", a, f);
            }
            if (a + b + c == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", a, b, c);
            }
            if (a + b + d == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", a, b, d);
            }
            if (a + b + f == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", a, b, f);
            }
            if (a + c + f == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", a, c, f);
            }
            if (a + c + d == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", a, c, d);
            }
            if (a + d + f == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", a, d, f);
            }
            if (a + b + c + d == 0)
            {
                Console.WriteLine("{0}+{1}+{2}+{3}=0", a, b, c, d);
            }
            if (a + c + d + f == 0)
            {
                Console.WriteLine("{0}+{1}+{2}+{3}=0", a, c, d, f);
            }

            if (a + b + d + f == 0)
            {
                Console.WriteLine("{0}+{1}+{2}+{3}=0", a, b, d, f);
            }
            if (a + b + c + f == 0)
            {
                Console.WriteLine("{0}+{1}+{2}+{3}=0", a, b, c, f);
            }
            if (b + c + d == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", b, c, d);
            }
            if (b + c + f == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", b, c, f);
            }
            if (b + c + d + f == 0)
            {
                Console.WriteLine("{0}+{1}+{2}+{3}=0", b, c, d, f);
            }
            if (b + c + d == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", b, c, d);
            }
            if (b + c + f == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", b, c, f);
            }
            if (b + d + f == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", b, d, f);
            }
            if (b + c == 0)
            {
                Console.WriteLine("{0}+{1}=0", b, c);
            }
            if (b + d == 0)
            {
                Console.WriteLine("{0}+{1}=0", b, d);
            }
            if (b + f == 0)
            {
                Console.WriteLine("{0}+{1}=0", b, f);
            }
            if (c + d + f == 0)
            {
                Console.WriteLine("{0}+{1}+{2}=0", c, d, f);
            }
            if (c + d == 0)
            {
                Console.WriteLine("{0}+{1}=0", c, d);
            }
            if (c + f == 0)
            {
                Console.WriteLine("{0}+{1}=0", c, f);
            }
            if (d + f == 0)
            {
                Console.WriteLine("{0}+{1}=0", d, f);
            }
            else
            {
                Console.WriteLine("no zero subset");
            }

        }
    }
}

