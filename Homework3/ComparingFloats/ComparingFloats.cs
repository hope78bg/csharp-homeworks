using System;



class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        double firstNumber=double.Parse(Console.ReadLine());
        double secondNumber=double.Parse(Console.ReadLine());
        double differenceNumber=(firstNumber-secondNumber);
        double eps = 0.000001;
        bool checkNum = Math.Abs(differenceNumber) < eps;
        if (Math.Abs(differenceNumber) < eps)
        {
            Console.WriteLine(checkNum); 
        }
        else if (Math.Abs(differenceNumber) >= eps)
        {
        
            Console.WriteLine(checkNum);
        }
    }
}

