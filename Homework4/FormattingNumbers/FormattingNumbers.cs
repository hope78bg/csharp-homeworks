using System;


class FormattingNumbers
{
    static void Main()
    {
        int integerNumber = int.Parse(Console.ReadLine());
        float firstFloatNumber = float.Parse(Console.ReadLine());
        float secondFloatNumber = float.Parse(Console.ReadLine());
        Console.WriteLine("|{0,-10:x}|{1,10}|{2,10:F2}|{3,-10:F3}|",
            integerNumber,Convert.ToString(integerNumber,2).PadLeft(10,'0'),
            firstFloatNumber,secondFloatNumber);
    }
}

