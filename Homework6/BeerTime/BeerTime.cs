using System;
using System.Globalization;
using System.Threading;


class BeerTime
{
    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        Console.Write("Please enter the time: ");
        DateTime dt;
        if (!DateTime.TryParse(Console.ReadLine(), out dt))
        {
            Console.WriteLine("invalid time");
        }
        else
        {
            TimeSpan ts = dt.TimeOfDay;
            if ((ts.Hours > 3) && (ts.Hours < 13))
            {
                Console.WriteLine("non-beer time");
            }
            else
            {
                Console.WriteLine("beer time");
            }
        }
    }
}
