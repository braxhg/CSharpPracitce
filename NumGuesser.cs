using System;

class NumGuesser
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int target = random.Next(1, 11); //Picks a number between 1 and 10

        Console.WriteLine("Welcome to the number guessing game!\nI will pick a number between 1 and 10!\nYou have to guess it!\nLet's go!");

        int guess;
        bool guessedCorrectly = false;

        while (!guessedCorrectly)
        {
            Console.Write(">> ");
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                if (guess > target)
                {
                    Console.WriteLine("Too high!");
                }
                else if (guess < target)
                {
                    Console.WriteLine("Too low!");
                }
                else
                {
                    Console.WriteLine("You got it!");
                    guessedCorrectly = true;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
