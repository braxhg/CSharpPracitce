using System;

class Untitled
{
	static void Main(string[] args)
	{
		Random random = new Random();
		int target = Convert.ToInt32(random.Next(1,10));
		
		Console.WriteLine("Welcome to the number guessing game!\nI will pick a number between 1 and 10!\nYou have to guess it!\nLet's go!");
		int guess = Convert.ToInt32(Console.ReadLine());
		//Console.WriteLine(randomNumber);
		
		do
		{
			if (guess > target)
			{
				Console.WriteLine("Too high!");
			}
			else if (guess < target)
			{
				Console.WriteLine("Too low!");
			}
			else if (guess == target)
			{
				Console.WriteLine("You got it!");
				break;
			}
			guess = Convert.ToInt32(Console.ReadLine());
		} while (guess != target);
	}
}
