using System;

namespace SortingNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; ++i)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
