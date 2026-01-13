using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // static void DisplayMessage()
        // {
        //     Console.WriteLine("Hello world!");
        // }
        // Python
        // def display_message():
        //     print("Hello World")

        // static void DisplayPersonalMessage(string userName)
        // {
        //     Console.WriteLine($"Hello {userName}");
        // }
        // Python
        // def display_personal_message(user_name):
        //     print(f"Hello {user_name}")

        // static int AddNumbers(int first, int second)
        // {
        //     int sum = first + second;
        //     return sum;
        // }
        // def add_numbers(first, second):
        //     sum = first + second
        //     return sum

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter favorite number: ");
            string userNumber = Console.ReadLine();
            int number = int.Parse(userNumber);
            return number;
        }

        static int SquareNumber(int squareNumber)
        {
            squareNumber = squareNumber * squareNumber;
            return squareNumber;
        }

        static void DisplayResult()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int number = PromptUserNumber();
            int squareNumber = SquareNumber(number);
            Console.WriteLine($"{userName}, the square of your number is: {squareNumber}");
        }

        DisplayResult();
    }
}