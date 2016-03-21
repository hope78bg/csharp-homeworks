using System;


class PrintADeckof52Cards
{
    public static void Main(string[] args)
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        char[] colors = {'\u2663', '\u2666', '\u2665', '\u2660' };
        foreach (var card in cards)
        {
            foreach (var color in colors)
            {
                Console.Write("{0}{1} ", card, color);
            }
            Console.WriteLine();
        }
    }
}

