using System;


class OddAndEvenProduct
{
    public static void Main(string[] args)
    {
        string[] elts = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
        int len = elts.Length;

        int productOdd = 1;
        for (int i = 0; i < len; i += 2)
        {
            productOdd *= int.Parse(elts[i]);
        }

        int productEven = 1;
        for (int i = 1; i < len; i += 2)
        {
            productEven *= int.Parse(elts[i]);
        }

        if (productEven == productOdd)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", productEven);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}\neven_product = {1}", productOdd, productEven);
        }
    }
}
