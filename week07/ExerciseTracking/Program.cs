using System;
using System.Xml.Serialization;


class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> _activities = new List<Activity>();

        string dateTime = DateTime.Now.ToString("dd MMM yyyy");
        Running running = new Running(dateTime, 30, 4);
        Bicycle bicycle = new Bicycle(dateTime, 140, 40); // The speed is not working on any of them
        Swimming swimming = new Swimming(dateTime, 30, 12)  ; // The pace and distance isn't working
        _activities.Add(running);
        _activities.Add(bicycle);
        _activities.Add(swimming);

        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }



    }
}