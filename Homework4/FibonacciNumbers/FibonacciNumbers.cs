using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Number n = ");
        string input = Console.ReadLine();
        ulong a = 0;
        ulong b = 1;
        for (uint n = uint.Parse(input); n > 0; --n)
        {
            Console.Write("{0} ", a);
            ulong c = a + b;
            a = b;
            b = c;
        }
    }
}
