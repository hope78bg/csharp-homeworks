using System;

namespace LongestareaInArray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] strings = new string[n];
            for (int i = 0; i < n; ++i)
            {
                strings[i] = Console.ReadLine();
            }
            if (n>0)
            {
                string longest = "";
                int longestN = 0;
                string w = strings[0];
                int m = 1;
                for (int i = 1; i < n; ++i)
                {
                    if (strings[i].Equals(w))
                    {
                        m++;
                    }
                    else
                    {
                        if (longestN < m)
                        {
                            longestN = m; 
                            longest = w;
                        }
                        w = strings[i];
                        m = 1;
                    }
                }
                if (longestN < m)
                {
                    longestN = m; 
                    longest = w;
                }
                Console.WriteLine(longestN);
                for (int i = 0; i < longestN; ++i)
                {
                    Console.WriteLine(longest);
                }
            }
        }
    }
}
