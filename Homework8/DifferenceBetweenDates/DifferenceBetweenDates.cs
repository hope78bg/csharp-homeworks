using System;

namespace DifferenceBetweenDates
{
    class MainClass
    {
        /*
        private static DateTime readDate(string date)
        {
            string[] arr = date.Split(new char[]{ '.' });

            int day = int.Parse(arr[0]);
            int month = int.Parse(arr[1]);
            int year = int.Parse(arr[2]);

            return new DateTime(year, month, day);
        }
        */

        public static void Main(string[] args)
        {
            Console.Write("Enter fisrt date (dd.MM.yyyy): ");
            DateTime date1 = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
            Console.Write("Enter second date (dd.MM.yyyy): ");
            DateTime date2 = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

            Console.WriteLine(date2.Subtract(date1).Days);
        }
    }
}
