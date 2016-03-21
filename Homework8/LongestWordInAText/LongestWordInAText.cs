using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LongestWordInAText
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] sentence = input.Split(' ');
        string longestWord=sentence[0];
        foreach (string word in sentence) {
            if (word.Length > longestWord.Length) {
                longestWord=word;
            }
        }
            
        Console.WriteLine("The longest word is: {0}", longestWord);
    }
}

