﻿using System;

class Sequence
{
    static void Main()
    { 
        for (int i = 2; i <= 501; i++)
        {
            if (i % 2 == 0)
            { 
                Console.WriteLine(i); 
            }
            else
            { 
                Console.WriteLine(i * (-1)); 
            } 
        } 
    }
}