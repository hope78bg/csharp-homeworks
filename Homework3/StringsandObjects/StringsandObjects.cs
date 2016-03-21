using System;


class StringsAndObjects
{
    static void Main()
    {
        string first = "Hello";
        string second = "World";
        object sumfs = first + " " + second;
        string third = (string)sumfs;


        Console.WriteLine("{0}, {1}, {2}, {3}\n", first, second, sumfs, third);
    }
}

