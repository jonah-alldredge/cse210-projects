public class BreathingActivity : Activity
{
    public BreathingActivity(string nameOfActivity, string description, int duration) : base(nameOfActivity, description, duration)
    {
        _duration = duration;
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.Write("Get Ready...");
        ShowCountDown(3);
        int runTime = _duration / 10;
        for (int i = 0; i < runTime; i++)
        {
            Console.Write("\n\nBreath in...");
            for (int n = 4; n > 0; n--)
            {
                Console.Write(n);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Write("\nNow Breath out...");
            for (int b = 6; b > 0; b--)
            {
                Console.Write(b);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        DisplayEndingMessage();
    }
}