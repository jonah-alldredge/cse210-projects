using System;
// I made it so the user is able to enter any scripture they want and practice with that scripture.
class Program
{
    static void Main(string[] args)
    {
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
        string userScripture = "Trust in the Lord with all your heart, And lean not on your own understanding; In all your ways acknowledge Him, And He shall direct your paths";
        Scripture scripture = new Scripture(userReference, userScripture);
        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress 'Enter' to continue or type 'quit' to finish: ");
            userEntry = Console.ReadLine();
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("You have finished! Press Enter when done.");
                Console.ReadLine();
                break;
            }
        } while (userEntry != "quit");
        if (userEntry == "quit")
        {
            Console.WriteLine("Thanks for playing!");
        }

    }
}