using System;


class SumOfNNumbers
{
    static void Main()
    {
        
        Console.Write("Number n = ");
        string input = Console.ReadLine();
        uint n = uint.Parse(input);
        decimal sum = 0;
        for (int i = 0; i < n; ++i)
        {
            Console.Write("number [{0}] = ", i + 1);
            string d = Console.ReadLine();
            decimal num = decimal.Parse(d);
            sum += num;
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}