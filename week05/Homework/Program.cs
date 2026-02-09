using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("7.3", "8-19", "Roberto Rodriquez", "Fractions");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}