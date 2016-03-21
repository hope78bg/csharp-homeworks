using System;


class AgeAfterTenYears
{
    public static void Main()
    {
       
        string date = Console.ReadLine();
        DateTime dt = Convert.ToDateTime(date);   
        //Console.WriteLine("Year: {0}, Month: {1}, Day: {2}", dt.Year, dt.Month, dt.Day);
        DateTime now = DateTime.Now;
        int years = now.Year - dt.Year;
        if ((now.Month < dt.Month) || ((now.Month == dt.Month) && (now.Day < dt.Day)))
        {
            --years;
        }
        //Console.WriteLine("You are born on {0}-{1}-{2} (Y-M-D)", dt.Year, dt.Month, dt.Day);
        Console.WriteLine("Now: {0}", years);
        Console.WriteLine("After 10 years: {0}", years + 10);
    }
}