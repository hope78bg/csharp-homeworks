using System;

class PrintTheASCIITable
{
    static void Main()
    {
        for (int i = 32; i <= 255; ++i)
        {
            
           // Console.WriteLine("0x{0:X} {1}", i, (char)i);      
            Console.WriteLine((char)i);
          // Console.WriteLine("| {0} | 0x{0:X} | {1} |", i, (char)i);
        }
    }
}
