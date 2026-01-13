using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // List<int> numbers;
        // List<string> words;
        // List<int> numbers = new List<int>();
        List<string> words = new List<string>();

        words.Add("phone");
        words.Add("keyboard");
        words.Add("mouse");

        Console.WriteLine(words.Count); // This is the same as print(len(words))

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
        // With Python:
        // for word in words:
        //      print(word)

        for (int i = 0; i < words.Count; i++)
        {
            Console.WriteLine(words[i]);
        }
        // for i in range (len(words)):
        //    print(words[i])
        int number = 1;
        int sum = 0;
        double average = 0;
        int counter = 0;
        int largestNumber = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string userNumber = Console.ReadLine();
            number = int.Parse(userNumber);
            if (number != 0)
            {
                sum = number + sum;
                counter += 1;
                // Console.WriteLine($"counter = {counter}");
            }
            if (largestNumber < number)
            {
                largestNumber = number;
            }
        }
        average = (double)sum / counter;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}