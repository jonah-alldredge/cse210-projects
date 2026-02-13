public class ListingActivity : Activity
{
    private int _count;
    List<string> _prompts = new List<string>();

    public ListingActivity(string nameOfActivity, string description, int duration) : base(nameOfActivity, description, duration)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        _duration = duration;
        _count = 0;
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.Write("Get Ready...");
        ShowCountDown(3);
        GetRandomPrompt();
        GetListFromUser();
        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        Random randomNumber = new Random();
        int randomPrompt = randomNumber.Next(0, _prompts.Count());
        Console.WriteLine("\nList as many responses you can to the following prompt: ");
        Console.WriteLine($" ---{_prompts[randomPrompt]}--- ");
        Console.Write("You may begin in...");
        ShowCountDown(3);
        Console.WriteLine();
    }
    public List<string> GetListFromUser()
    {
        List<string> userInputList = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (endTime > DateTime.Now)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            userInputList.Add(userInput);
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");
        return userInputList;
    }
}