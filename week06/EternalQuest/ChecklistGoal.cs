using System.ComponentModel;

public class ChecklistGoal: Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string shortName, string description, int points, int amountCompleted, int target, int bonus): base(shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public void RecordEvent()
    {

    }
    public bool IsComplete()
    {
        return true;
    }
    public string GetDetailString()
    {
        return "";
    }
    public string GetStringRepresentation()
    {
        return "";
    }
}