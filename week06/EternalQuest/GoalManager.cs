// I added a level up system, every 100 points you gain a level
using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _levelUp;

    public GoalManager()
    {
        Start();
    }
    public void Start()
    {
        string playerChoice = "";
        _score = 0;
        _levelUp = 0;
        while (playerChoice != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            playerChoice = Console.ReadLine();
            if (playerChoice == "1") // CreateGoal
            {
                CreateGoal();
            }
            else if (playerChoice == "2") // List Goals
            {

                ListGoalDetails();
            }
            else if (playerChoice == "3") // Save Goals
            {
                SaveGoals();
            }
            else if (playerChoice == "4") // Load Goals
            {
                LoadGoals();
            }
            else if (playerChoice == "5") // Record Goals
            {
                RecordEvent();
            }
            else
            {
                if (playerChoice != "6")
                {
                    Console.WriteLine("Please enter a valid response!");
                }
            }
            if(_score >= 100)
            {
                while(_score >= 100)
                {
                    _levelUp++;
                    _score -= 100;
                }
            }
        }

    }
    public void DisplayPlayerInfo() // Displays the players current score
    {
        Console.Clear();
        Console.WriteLine($"You have {_score} Points and you're level {_levelUp}");
    }
    public void CreateGoal() // (ask user for new goal info, & add to list)
    {
        Console.Clear();
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of Goal would you like to create? ");
        string goalType = Console.ReadLine();
        if (goalType == "1")
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("Type a short description of the goal: ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points awarded to this goal? ");
            string pointsString = Console.ReadLine();
            int points = int.Parse(pointsString);
            SimpleGoal simpleGoal = new SimpleGoal(goalName, description, points, false);
            _goals.Add(simpleGoal);
        }
        else if (goalType == "2")
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("Type a short description of the goal: ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points awarded to this goal? ");
            string pointsString = Console.ReadLine();
            int points = int.Parse(pointsString);
            EternalGoal eternalGoal = new EternalGoal(goalName, description, points);
            _goals.Add(eternalGoal);
        }
        else if (goalType == "3")
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("Type a short description of the goal: ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points awarded for each step? ");
            string points = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string bonusPoints = Console.ReadLine();
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonusFinish = Console.ReadLine();
            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, description, int.Parse(points), int.Parse(bonusPoints), int.Parse(bonusFinish), 0);
            _goals.Add(checklistGoal);
        }
    }
    public void ListGoalNames() // Lists the names of each of the goals
    {
        int numberGoals = 1;
        foreach (Goal goal in _goals)
        {
            string stringName = $"{numberGoals}. {goal.GetDetailString()}\n";
            Console.Write(stringName);
            numberGoals++;      
        }
        
    }
    public void ListGoalDetails() // Lists the details of each goal(including the checkbox of whether it is complete)
    {
        Console.Clear();
        Console.WriteLine("Here are your goals: ");
        int numberGoals = 1;
        foreach (Goal goal in _goals)
        {
            string getWholeString = $"{numberGoals}. {goal.GetStringRepresentation()}\n";
            Console.Write(getWholeString);
            numberGoals++;
        }
        Console.WriteLine("\nPress Enter to continue");
        Console.ReadLine();
    }
    public void RecordEvent() // (calls individual goal classes) and checks whether they are done or not?
    {
        Console.Clear();
        Console.WriteLine("The Goals are: ");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string stringAccomplishedGoal = Console.ReadLine();
        int accomplishedGoal = int.Parse(stringAccomplishedGoal);
        accomplishedGoal--;
        if (_goals[accomplishedGoal].IsComplete())
        {
            Console.WriteLine("Sorry that goal is already complete!");
        }
        else if (!_goals[accomplishedGoal].IsComplete())
        {
            int points = _goals[accomplishedGoal].RecordEvent();
            _score += points;
            Console.WriteLine($"Congrats!! You gained {points} points!");
        }
        else
        {
            Console.WriteLine("Please enter a valid Goal number");
        }
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
    }
    public void SaveGoals() // Saves the list of goals to a file
    {
        Console.Clear();
        Console.Write("Which file would you like to save it to? ");
        string fileName = Console.ReadLine();
        // string fileName = "goals.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            outputFile.WriteLine(_levelUp);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveStringName());
            }
        }
    }
    public void LoadGoals() // Loads the list of goals from a file
    {
        Console.Clear();

        Console.Write("Which file would you like to load? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        string stringPoints = lines[0];
        _score = int.Parse(stringPoints);
        string stringLevelUp = lines[1];
        _levelUp = int.Parse(stringLevelUp);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~");
            string goalFullName = parts[0];
            if (goalFullName.Contains("SimpleGoal"))
            {
                string goalName = SeparateName(goalFullName);
                string goalDescription = parts[1];
                string goalStringPoints = parts[2];
                int goalPoints = int.Parse(goalStringPoints);
                string goalStringComplete = parts[3];
                bool goalIsComplete = bool.Parse(goalStringComplete);
                SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints, goalIsComplete);
                _goals.Add(simpleGoal);
            }
            else if (goalFullName.Contains("EternalGoal"))
            {
                string goalName = SeparateName(goalFullName);
                string goalDescription = parts[1];
                string goalStringPoints = parts[2];
                int goalPoints = int.Parse(goalStringPoints);
                EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                _goals.Add(eternalGoal);
            }
            else if (goalFullName.Contains("ChecklistGoal"))
            {
                string goalName = SeparateName(goalFullName);
                string goalDescription = parts[1];
                string goalStringPoints = parts[2];
                int goalPoints = int.Parse(goalStringPoints);
                string goalStringBonus = parts[3];
                int goalBonus = int.Parse(goalStringBonus);
                string goalStringTarget = parts[4];
                int goalTarget = int.Parse(goalStringTarget);
                string goalStringAmountCompleted = parts[5];
                int goalAmountCompleted = int.Parse(goalStringAmountCompleted);
                ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus, goalAmountCompleted);
                _goals.Add(checklistGoal);
            }
        }
    }
    public string SeparateName(string line)
    {
        string[] parts = line.Split(":");
        string goalName = parts[1];
        return goalName;
    }


}