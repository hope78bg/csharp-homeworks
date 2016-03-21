﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExtractUrlsFromText
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter your text: ");
        string input = Console.ReadLine();
        string[] text = input.Split();
        List<string> results = new List<string>();
        foreach (string link in text)
        {
            if (!results.Contains(link) && (link.Length > 6))
            {
                if (link.Substring(0, 7) == "http://" || (link.Substring(0, 4) == "www."))
                {
                    results.Add(link);
                }
            }
        }
        foreach(string link in results)
        {
            Console.WriteLine("{0} ", link);
        }
    }
}

