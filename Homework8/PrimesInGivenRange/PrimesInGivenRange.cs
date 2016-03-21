using System;
using System.Collections.Generic;

namespace PrimesInGivenRange
{
    class MainClass
    {
        static List<ulong> FindPrimesInRange(ulong startNum, ulong endNum)
        {
            startNum = Math.Max(startNum, 2);
            List<ulong> l = new List<ulong>();
            for (ulong i = startNum; i <= endNum; ++i)
            {
                if (PrimeChecker.MainClass.IsPrime(i))
                {
                    l.Add(i);
                }
            }
            return l;
        }


        public static void Main(string[] args)
        {
            ulong startNum = ulong.Parse(Console.ReadLine());
            ulong endNum = ulong.Parse(Console.ReadLine());
            List<ulong> l = FindPrimesInRange(startNum, endNum);
            if (l.Count > 0)
            {
                Console.Write("{0}", l[0]);
                l.Remove(0);
                foreach (var item in l)
                {
                    Console.Write(", {0}", item);
                }
            }
            else
            {
                Console.WriteLine("(empty list)");
            }
        }
    }
}
