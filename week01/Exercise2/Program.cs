using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        int sign = grade % 10;
        string gradeSign = "";
        string gradeLetter = "";
        if (sign >= 7)
        {
            gradeSign = "+";
        }
        else if (sign < 3)
        {
            gradeSign = "-";
        }
        if (grade >= 90)
        {
            gradeLetter = "A";
        }
        else if (grade >= 80)
        {
            gradeLetter = "B";
        }
        else if (grade >= 70)
        {

            gradeLetter = "C";
        }
        else if (grade >= 60)
        {

            gradeLetter = "D";
        }
        else if (grade < 60)
        {
            gradeLetter = "F";
        }
        if (grade > 60 & grade < 97)
        {
            Console.WriteLine($"You have a {gradeLetter}{gradeSign} in the class");
        }
        else
        {
            Console.WriteLine($"You have a {gradeLetter} in the class");
        }
    }
}