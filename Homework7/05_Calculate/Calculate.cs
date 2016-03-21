using System;


class Calculate
{
    public static void Main()
    {
        Console.Write("Pleace,enter number n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Pleace,enter  number x= ");
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        int fact = 1;
        int power_x = 1;
        for (int i = 1; i <=n ;i++)
        {
            fact *= i;
            power_x *= x;
            sum += (double)fact / power_x;
        }

        Console.WriteLine ("{0:F5}",sum);
    }
}
