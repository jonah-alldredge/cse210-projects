using System;
// Need to fix IsCompletelyHidden
// I'm trying to do a while loop to loop it until all the words are disappeared
// I need to somehow take out the words from the list that are already gone
class Program
{
    static void Main(string[] args)
    {
        // "Trust in the Lord with all your heart, And lean not on your own understanding; In all your ways acknowledge Him, And He shall direct your paths"
        Console.Clear();
        string userEntry = "";
        Console.WriteLine("Welcome To The Scripture Memorizer 9000!");
        Console.WriteLine("Please Enter Any Scripture Ex. Proverbs 3:5-6");
        Console.WriteLine("Enter the Book you want to study from: ");
        string userBook = Console.ReadLine();
        Console.WriteLine("Enter the Chapter: ");
        string userChapter = Console.ReadLine();
        Console.WriteLine("Are you entering multiple verses? (y/n): ");
        string userMultipleVerses = Console.ReadLine();
        Reference userReference;

        if (userMultipleVerses == "y")
        {
            Console.WriteLine("Enter the First Verse: ");
            string firstVerse = Console.ReadLine();
            Console.WriteLine("Enter the Last Verse: ");
            string lastVerse = Console.ReadLine();
            userReference = new Reference(userBook, int.Parse(userChapter), int.Parse(firstVerse), int.Parse(lastVerse));
        }

        else
        {
            Console.WriteLine("Enter the Verse:");
            string userVerse = Console.ReadLine();
            userReference = new Reference(userBook, int.Parse(userChapter), int.Parse(userVerse));
        }
        Console.WriteLine("Enter the Scripture: ");
        string userScripture = Console.ReadLine();
        Scripture scripture = new Scripture(userReference, userScripture);
        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress 'Enter' to continue or type 'quit' to finish: ");
            userEntry = Console.ReadLine();
        } while (userEntry != "quit");
    }
}