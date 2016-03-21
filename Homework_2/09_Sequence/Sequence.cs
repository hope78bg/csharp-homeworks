using System;

class Sequence
{
	static void Main()
	{
        Console.Write(2);
		for (int i = 3; i <= 11; i++)
		{
            Console.Write(",");
			if (i % 2 == 0)
			{ 
				Console.Write(i);
			}
			else
			{ 
				Console.Write(i * (-1)); 
			}
		}
	}
}