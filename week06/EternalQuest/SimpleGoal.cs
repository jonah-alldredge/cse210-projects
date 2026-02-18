public class SimpleGoal:Goal
{
    private bool _isComplete;
    private int _points;

    public SimpleGoal(string shortName, string description, int points, bool isComplete) : base(shortName, description, points)
    {
        _points = points;
        _isComplete = isComplete;
    }
    public override int RecordEvent() // Marks the goal as completed - Calls IsCompleted? and then says it is complete?
    {
        _isComplete = true;
        IsComplete();
        return _points;
    }
    public override bool IsComplete() // Returns if the goal is complete or not
    {
        if (_isComplete)
        {
            return true;
        }
        return false;
    }
    public override string SaveStringName()
    {
        string goalComplete;
        if (IsComplete())
        {
            goalComplete = "True";
        }
        else
        {
            goalComplete = "False";
        }
        string saveString = $"SimpleGoal:{base.SaveStringName()}~{goalComplete}";
        return saveString;
    }

}