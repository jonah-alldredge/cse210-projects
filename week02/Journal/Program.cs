using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        /* 1. New Journal Entry 
                You show them a random prompt (probably from a list you created)
           2. Display Journal Entries
                You iterate through all journal entries and DISPLAY them
           3. Save Journal to a File
                Prompt user for a filename (where they want it saved) have it save ALL prompts to that location
                **My question is, do they need to be saved as individual files each or just into one big file?
           4. (UP)Load Journal from File
                Ask for a file name (Direct Path?) and load journal (replacing any currently stored entries)
            5. Quit
        ** Must provide a list of (at least 5) prompts & MENU allowing user to choose option
        */
        string userInput;
        string userEntry;
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. New Journal Entry");
            Console.WriteLine("2. Display All Journal Entries");
            Console.WriteLine("3. Load File");
            Console.WriteLine("4. Save to File");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Entry entry1 = new Entry();
                entry1.Display();
                userEntry = Console.ReadLine();
                entry1._entry = userEntry;

                DateTime todayDate = DateTime.Today;
                entry1._dateTime = todayDate;
                Console.WriteLine(entry1._dateTime);
                Console.WriteLine(entry1._entry);
                Console.WriteLine(entry1._prompt);
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Pass\n");
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Pass\n");
            }
            else if (userInput == "4")
            {
                Console.WriteLine("Pass\n");
            }
            else if (userInput != "5")
            {
                Console.WriteLine("Please enter a valid input.\n");
            }

        } while (userInput != "5");
        Console.WriteLine("Thanks for playing!");
    }
}