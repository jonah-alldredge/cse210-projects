using System;

class Program
{
    //     Have a menu system to allow the user to choose an activity.
    // Each activity should start with a common starting message that provides the name of the activity, a description, and asks for and sets the duration of the activity in seconds.
    // Then, it should tell the user to prepare to begin and pause for several seconds.
// Each activity should end with a common ending message that tells the user they have done a good job, and pause and then tell them the activity they have completed and the length of time and pauses for several seconds before finishing.
// Whenever the application pauses it should show some kind of animation to the user, such as a spinner, a countdown timer, or periods being displayed to the screen.
// The interface for the program should remain generally true to the one shown in the video demo.
// Provide activities for reflection, breathing, and enumeration, as described below:
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        string userInput = "";
        while (userInput != "4")
        {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflecting Activity");
        Console.WriteLine("3. Start Listening Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        userInput = Console.ReadLine();
            if (userInput == "1")
            {
                BreathingActivity activity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
                activity.Run();
            }
            else if (userInput == "2")
            {
                ReflectionActivity activity = new ReflectionActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                activity.Run();
            }
            else if (userInput == "3")
            {
                ListingActivity activity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
                activity.Run();
            }
            Console.Clear();
        }
    }
}