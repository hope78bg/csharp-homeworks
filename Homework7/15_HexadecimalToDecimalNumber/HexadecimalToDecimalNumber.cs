using System;


class HexadecimalToDecimalNumber
{
    public static void Main()
    {
        Console.Write("Enter your Hexadecimal number: ");
        string input = Console.ReadLine();
        long decsum = 0;
        int lastIndex = input.Length - 1;
        for (int i = 0; i <input.Length ; i++,lastIndex--)
        {
            int currentNumberInHex;
            switch (input[i])
            {
                case'A':
                    currentNumberInHex = 10;
                    break;
                case'B':
                    currentNumberInHex = 11;
                    break;
                case'C':
                    currentNumberInHex = 12;
                    break;
                case'D':
                    currentNumberInHex = 13;
                    break;
                case'E':
                    currentNumberInHex = 14;
                    break;
                case'F':
                    currentNumberInHex = 15;
                    break;
                default:
                    currentNumberInHex = int.Parse(input[i].ToString()); 
                    break;
            }
            long hexSum = 1;
            for (int j = 0; j < lastIndex; j++)
            {
                hexSum *= 16;
            }
            hexSum *= currentNumberInHex;
            decsum += hexSum;
        }
        Console.WriteLine(decsum);
    }
}

