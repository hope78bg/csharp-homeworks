using System;



class MinManSumAndAverageOfNNumbers
{
    public static void Main()
    {
        Console.Write("Enter amount of number n = ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int min = int.MaxValue;
        int max = int.MinValue;
        double average = 0;
        for (int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
            min = Math.Min(min, number);
            max = Math.Max(max, number);
            average = (sum / n);
        }
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("Age ={0:0.00}",average);
        Console.WriteLine("Min=" + min);
        Console.WriteLine("Max=" + max);
    }
}

