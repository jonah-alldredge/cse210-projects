public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {

    }
    public void Start()
    {
        string playerChoice = "";
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
                if(playerChoice != "6")
                {
                    Console.WriteLine("Please enter a valid response!");
                }
            }
        }

    }
    public void DisplayPlayerInfo() // Displays the players current score
    {
        Console.Clear();
        Console.WriteLine("You have 0 Points.");
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
            SimpleGoal simpleGoal = new SimpleGoal(goalName, description, points);
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
            Console.Write("What is the amount of points awarded to this goal? ");
            string points = Console.ReadLine();
            Console.Write("How many points are awarded for finishing the goal? ");
            string finishGoal = Console.ReadLine();
            Console.Write("How many time does this goal need to be accomplished for a bonus? ");
            string bonusPoints = Console.ReadLine();
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonusFinish = Console.ReadLine();
            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, description, int.Parse(points), int.Parse(finishGoal), int.Parse(bonusPoints), int.Parse(bonusFinish));
            _goals.Add(checklistGoal);
        }
    }
    public void ListGoalNames() // Lists the names of each of the goals
    {
        Console.Clear();
        Console.WriteLine("Listing Goal names");
        Console.WriteLine("Press enter when ready");
        Console.ReadLine();
    }
    public void ListGoalDetails() // Lists the details of each goal(including the checkbox of whether it is complete)
    {
        Console.Clear();
        Console.WriteLine("Listing the Details of each goal");
        Console.WriteLine("Press enter when ready");
        Console.ReadLine();
    }
    public void RecordEvent() // (calls individual goal classes) and checks whether they are done or not?
    {
        Console.Clear();
        Console.WriteLine("The Goals are: ");
        ListGoalNames();
        Console.Write("Which Goal did you accomplish? ");
        Console.ReadLine();
    }
    public void SaveGoals() // Saves the list of goals to a file
    {
        Console.Clear();
        Console.WriteLine("Saving Goals");
        Console.WriteLine("Press enter when ready");
        Console.ReadLine();
    }
    public void LoadGoals() // Loads the list of goals from a file
    {
        Console.Clear();
        Console.WriteLine("Loading Goals");
        Console.WriteLine("Press enter when ready");
        Console.ReadLine();
    }


}