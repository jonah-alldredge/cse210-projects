using System;
using System.IO.Enumeration;
class Program
{
    static void Main(string[] args)
    {
        /* 
        1. New Journal Entry 
                You show them a random prompt (probably from a list you created)
           2. Display Journal Entries
                You iterate through all journal entries and DISPLAY them
           3. Save Journal to a File
                Prompt user for a filename (where they want it saved) have it save ALL prompts to that location
           4. (UP)Load Journal from File
                Ask for a file name (Direct Path?) and load journal (replacing any currently stored entries)
            5. Quit
        */
        string userInput;
        string userEntry;
        Journal journal = new Journal();
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
                JournalEntry entry1 = new JournalEntry();
                entry1.Display();
                userEntry = Console.ReadLine();
                entry1._entry = userEntry;
                DateTime todayDate = DateTime.Today;
                string formattedDate = DateTime.Now.ToString("MM/dd/yyyy");
                entry1._dateTime = formattedDate;
                journal.AddEntry(entry1);
            }
            else if (userInput == "2")
            {
                journal.Display();
            }
            else if (userInput == "3")
            {
                Console.WriteLine("What file do you want to load? ");
                string fileName = Console.ReadLine() + ".txt";
                // string fileName = "JournalEntries.txt";
                Console.WriteLine("Loading file...");
                // Update the list to be the existing one
                journal.FileUpload(fileName);
                Console.WriteLine("File Uploaded...Continue Journaling...");
            }
            else if (userInput == "4")
            {
                Console.WriteLine("What file do you want to save it too? ");
                // string fileName = "JournalEntries.txt";
                string fileName = Console.ReadLine() + ".txt";
                journal.FileSave(fileName);
            }
            else if (userInput != "5")
            {
                Console.WriteLine("Please enter a valid input.\n");
            }
        } while (userInput != "5");
        Console.WriteLine("Thanks for Journaling!");
    }
}