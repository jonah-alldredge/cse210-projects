using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        Console.WriteLine("Guess a number between 1 and 10");
        Console.Write("Would you like to play?(yes or no) ");
        string play = Console.ReadLine();;
        
        while (play == "yes" )
        {
            int number = randomGenerator.Next(1, 11);
            int guessCounter = 0;
            int userNumber;
            do
            {
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                userNumber = int.Parse(userGuess);
                guessCounter = guessCounter + 1;
                if (userNumber > number)
                {
                    Console.Write("Lower\n");
                }
                else if (userNumber < number)
                {
                    Console.Write("Higher\n");
                }
            } while (number != userNumber);
            Console.WriteLine($"It took you {guessCounter} guesses");
            Console.Write("Would you like to play again?(yes or no) ");
            play = Console.ReadLine();
        }
    }
}