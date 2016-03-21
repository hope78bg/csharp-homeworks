using System;

class PrimeNumberCheck
{
    public static void Main()
    {
        Console.Write("a=");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine((a%2)*(a%3)*(a%5)*(a%7) != 0);
    }
}