using System;


class ZeroSubset1
{
    public static void Main(string[] args)
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("d = ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("f = ");
        int f = int.Parse(Console.ReadLine());


        int[] nums = {a, b, c, d, f};
        int subsets = 0;

        for (int pattern = 1; pattern < 32; ++pattern)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < 5; ++i)
            {
                if (((1 << i) & pattern) != 0)
                {
                    sum += nums[i];
                    ++count;
                }
            }
            if (sum == 0)
            {
                for (int i = 0; i < 5; ++i)
                {
                    if (((1 << i) & pattern) != 0)
                    {
                        Console.Write(nums[i]);
                        --count;
                        if (count > 0)
                        {
                            Console.Write(" + ");
                        }
                        else
                        {
                            Console.WriteLine(" = 0");
                        }
                    }
                }
                ++subsets;
            }
        }
        if (subsets == 0)
        {
            Console.WriteLine("no zero subset");
        }
    }
}

