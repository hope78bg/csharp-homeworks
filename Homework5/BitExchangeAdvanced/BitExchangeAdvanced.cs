using System;

class BitExchangeAdvanced
{
    public static void Main()
    {
        Console.Write("n = ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("q = ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        if ((p + k > 32) || (q + k > 32))
        {
            Console.WriteLine("out of range");
        }
        else if (((p <= q) && (p + k > q)) || ((p > q) && (q + k > p)))
        {
            Console.WriteLine("overlapping");
        }
        else
        {
            uint a = readBits(n, p, k);
            uint b = readBits(n, q, k);
            n = writeBits(n, p, k, b);
            n = writeBits(n, q, k, a);
            Console.WriteLine(n);
        }
    }

    private static uint readBits(uint number, int position, int numBits)
    {
        return (number & (((1u << numBits) - 1) << position)) >> position;
    }

    private static uint writeBits(uint number, int position, int numBits, uint value)
    {
        return (~(((1u << numBits) - 1) << position) & number) | (value << position);
    }
}

