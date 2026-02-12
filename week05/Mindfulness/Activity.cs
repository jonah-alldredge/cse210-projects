public class Activity
{
    //Start with a common message providing name of activity
    //Description
    //Asks for & sets duration (in seconds)
    //Tells user to prepare to begin then pauses for several seconds

    //Runs other activity

    //Ends saying GOOD JOB
    //Pause, tell them which activity was completed and for how long
    //Pauses for several seconds

    //**Whenever paused it will have an animation
    //Normal interface
    //Attributes:
    private string _nameOfActivity;
    private string _description;
    protected int _duration;

    //Methods:
    /*
        - Display starting Message
        - Display ending Message
        - Pause w/ spinner for certain seconds
        - Pause w/ countdown timer
    */

    //Constructor:
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
        // Console.Clear();
        Console.WriteLine("\nWell Done!!");
        ShowSpinner(2);
        Console.WriteLine($"\nYou have completed another {_duration} seconds in the {_nameOfActivity} Activity");
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