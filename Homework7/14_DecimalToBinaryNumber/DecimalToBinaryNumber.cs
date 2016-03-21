using System;


class DecimalToBinaryNumber
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your nomber n;");
        long n = long.Parse(Console.ReadLine());
        string biraryLength="";
            while(n!=0)
                {
                    int remain=(int)n%2;
                    n/=2;
                    biraryLength=remain+biraryLength;
                }
                    
            Console.WriteLine(biraryLength);
    }
}

