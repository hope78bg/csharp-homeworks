using System;

class SumOf5Numbers
{
    static void Main()
    {
        char[] separators = {' '};
        string[] arrayOfStrings = Console.ReadLine().Split(
            separators,
            StringSplitOptions.RemoveEmptyEntries);
        if (arrayOfStrings.Length == 5)
        {
            double sum = 0;
            for (int i = 0; i < arrayOfStrings.Length; ++i)
            {
                sum += int.Parse(arrayOfStrings[i]);       
            }
            Console.WriteLine(sum);
        }
        else 
        {
            Console.WriteLine("Error: incorrect number of elements");  
        }
    }
}

