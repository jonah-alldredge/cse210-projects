

public class ReflectionActivity : Activity
{
    //Give prompt, wait a few seconds to let them think
    //Give them reflection question relating to experience
    //Display a spinner when paused? 
    //Continue showing questions until # of seconds the user specified

    //Attributes:
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectionActivity(string nameOfActivity, string description, int duration) : base(nameOfActivity, description, duration)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _duration = duration;
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("Get Ready...");
        ShowCountDown(3);
        DisplayPrompt();
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random randomNumber = new Random();
        int randomPrompt = randomNumber.Next(0, _prompts.Count());
        return _prompts[randomPrompt];
    }

    public string GetRandomQuestion()
    {
        Random randomNumber = new Random();
        int randomQuestion = randomNumber.Next(0, _questions.Count());
        string question = _questions[randomQuestion];
        _questions.Remove(_questions[randomQuestion]);
        return question;
    }
    public void DisplayPrompt()
    {
        Console.Clear();
        Console.WriteLine("\nConsider the following prompt:\n");
        string prompt = GetRandomPrompt();
        Console.WriteLine($" --- {prompt} --- ");
        Console.WriteLine("When you have something in mind, press 'enter' to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.\n");
        Console.Write("You may begin in...");
        ShowCountDown(3);
        DisplayQuestion();
    }
    public void DisplayQuestion()
    {
        Console.Clear();
        int runTime = _duration / 10;
        for (double i = 0; i < runTime; i += 0.5)
        {
            string randomQuestion = GetRandomQuestion();
            Console.Write($"\n > {randomQuestion} ");

            ShowSpinner(3);
        }

    }

    //Methods:
    /*
        - Run
        - Get a random prompt
        - Get random question abt prompt (cycle through to eliminate them when used for each activity?)
        - Display the prompt
        - Display questions abt prompt & get answers? (User input?)
        - Private helper functions? 
    */
}