using System;

class FourDigitNumber
{
    public static void Main()
    {
        Console.Write("a=");
        int a = int.Parse(Console.ReadLine());
        int  last = a % 10;
        int b = a / 10;
        int third = b % 10;
        int c = b / 10;
        int second = c % 10;
        int d = c / 10;
        int first = d % 10;
        int sumOfDigits= last+third+second+first;
        Console.WriteLine("sum={0}\nreversed={1}{2}{3}{4}\nlastDigitinfront={5}{6}{7}{8}\nsecondAndThirdDE={9}{10}{11}{12}",
            sumOfDigits,last,third,second,first,last,first,second,third,first,third,second,last);
    }
}

