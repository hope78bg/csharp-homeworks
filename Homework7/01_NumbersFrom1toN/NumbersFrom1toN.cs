using System;

class NumbersFrom1toN
{
    public static void Main()
    {
        Console.Write("Enter your number n = ");
        int n = int.Parse(Console.ReadLine());
        for (int i =1; i <=n; ++i)
        {
            Console.Write((i == n) ? "{0}\n" : "{0} ", i);   
        }
                
       
    }
}

