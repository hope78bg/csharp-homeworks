using System;
class BinaryToDecimalNumber
{
    public static void Main()
    {
        Console.Write("Enter your binary number: ");
        string binary = Console.ReadLine();
        long sumdec = 0;
        int length = binary.Length;
        for (int i = 0; i < length; ++i) 
        {
            //sumdec = sumdec * 2 + (binary[i] - '0');
            sumdec += (binary[i] - '0') << (length - i - 1);
        }
        Console.WriteLine(sumdec);
    }
}

