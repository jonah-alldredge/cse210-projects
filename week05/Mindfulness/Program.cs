// ADDED A WAY FOR THE QUESTIONS TO BE TAKEN OUT SO THEY WEREN'T REPEATED

using System;

class Program
{
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