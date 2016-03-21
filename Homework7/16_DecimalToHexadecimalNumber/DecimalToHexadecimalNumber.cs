using System;


class DecimalToHexadecimalNumber
{
    public static void Main()
    {
        Console.Write("Enter your nomber n;");
        long n = long.Parse(Console.ReadLine());
        string hexNumber = "";
        if (n == 0)
        {
            hexNumber = "0";
        }
        else
        {
            while (n > 0)
            {
                long remain = n % 16;
                n /= 16;
                switch (remain)
                {
                    case 10: 
                        hexNumber = "A" + hexNumber;
                        break;
                    case 11:
                        hexNumber = "B" + hexNumber;
                        break;
                    case 12:
                        hexNumber = "C" + hexNumber;
                        break;
                    case 13:
                        hexNumber = "D" + hexNumber;
                        break;
                    case 14:
                        hexNumber = "E" + hexNumber;
                        break;
                    case 15:
                        hexNumber = "F" + hexNumber;
                        break;
                    default: 
                        hexNumber = remain + hexNumber;
                        break;
                }
                    
            }
            Console.WriteLine(hexNumber);
        }
    }

}