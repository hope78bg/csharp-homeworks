using System;


class Calculate
{
    public static void Main()
    {
        Console.Write("Pleace,enter number n=");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("Pleace,enter  number k= ");
        uint k = uint.Parse(Console.ReadLine());
        uint factorial = 1;
        uint factorialM = 1;
        double Result = 1;
        if (n > k && k > 1 && n < 100)
        {
            for (uint i = (k + 1); i <= n; i++)
            {
                factorial *= i;

            } 

           // Console.Write("factorial is {0} ", factorial);
            for (uint m = 1; m <= n-k; m++)
            {
                factorialM *= m;
            }
            Result = factorial /factorialM; 
            Console.WriteLine("Result is {0}", Result);
        }
        else
        {
            Console.WriteLine("invalid input");
        }

        
    }
}

