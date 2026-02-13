public class Activity
{
    private string _nameOfActivity;
    private string _description;
    protected int _duration;

    public Activity(string nameOfActivity, string description, int duration)
    {
        _nameOfActivity = nameOfActivity;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_nameOfActivity} Activity");
        Console.WriteLine($"\n{_description}");
        Console.WriteLine("\nHow long, in seconds, would you like for your session? ");
        Console.Write("Type in increments of 10(10, 20, 30...): ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell Done!!");
        ShowSpinner(2);
        Console.WriteLine($"\nYou have completed {_duration} seconds in the {_nameOfActivity} Activity");
        ShowSpinner(2);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        for(int i=0; i < seconds; i++)
        {
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(150);
                Console.Write("\b \b");
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i =0; i < seconds; seconds--)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}