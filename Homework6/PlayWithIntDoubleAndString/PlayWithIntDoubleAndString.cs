using System;


class PlayWithIntDoubleAndString
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("1--->int ");
        Console.WriteLine("2--->double ");
        Console.WriteLine("3--->string ");
        int choice = int.Parse(Console.ReadLine());


        switch (choice )
        {
            case 1:
                Console.Write("Please enter a int=");
                int choiceOne = int.Parse(Console.ReadLine());
                Console.WriteLine(choiceOne+1);
                break;
            case 2:
                Console.Write("Please enter a double=");
                double choiceTwo = double.Parse(Console.ReadLine());
                Console.WriteLine(choiceTwo+1);
                break;
            case 3:
                Console.Write("Please enter a string=");
                string choiceThree = Console.ReadLine();

                Console.WriteLine(choiceThree+ "*");
                break;
           
            default:
                Console.WriteLine("not a digit");
                break;
        }
        
    }
}

