using System;


class BitsExchange
{
    public static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        uint a = readBits(number, 3, 3);
        uint b = readBits(number, 24, 3);
        number = writeBits(number, 3, 3, b);
        number = writeBits(number, 24, 3, a);
        Console.WriteLine(number);
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

