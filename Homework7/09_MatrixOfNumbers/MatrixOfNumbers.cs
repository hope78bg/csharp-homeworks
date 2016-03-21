using System;


class MatrixOfNumbers
{
    public static void Main()
    {
        Console.Write("Pleace,enter number n=");
        int n = int.Parse(Console.ReadLine());
        if ((1 <= n) && (n <= 20))
        {
            for (int i = 1; i <= n; ++i)
            {
                for (int j = i; j < n+i; ++j)
                {
                   
                    Console.Write("{0}", j); 
                }
                Console.WriteLine();
            }
        }
            
            else
            {
                Console.WriteLine("invalid input");
            }
    }
}

