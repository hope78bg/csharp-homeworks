using System;


class BonusScorehttp
{
    public static void Main()
    {
        Console.Write("score=");
        int score = int.Parse(Console.ReadLine());
        if (1 <= score && score <= 3)       
        {
            
            Console.WriteLine("result {0}", score*10);
        }
            else if(4<=score && score<=6)
            {
            Console.WriteLine ("result {0}",score*100);
            }
            else if(7<=score&&score<=9)
            {
            
            Console.WriteLine ("result {0}",score*1000);
            }
            else if(0>=score || score>=9)
            {
            Console.WriteLine ("Invalid score  ");
            }

        //else
       // {

        //   Console.WriteLine ("Try again");
        //}


    }
}

