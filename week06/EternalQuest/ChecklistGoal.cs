using System.ComponentModel;

public class ChecklistGoal: Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private int _points;
    private bool _isComplete;
    public ChecklistGoal(string shortName, string description, int points, int target, int bonus, int amountCompleted): base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _points = points;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            _points = _bonus + _points;
            _isComplete = true;
            IsComplete();
        }
        else
        {
            return _points;
        }
        return _points;
    }
    public override bool IsComplete()
    {
        if (_isComplete)
        {
            return true;
        }
        return false;
    }
    public override string GetStringRepresentation()
    {

        string getHalfString = base.GetStringRepresentation();
        string getWholeString = $"{getHalfString} - Currently Completed: {_amountCompleted}/{_target}";
        return getWholeString;
    }
    public override string SaveStringName()
    {
        string saveString = $"ChecklistGoal:{base.SaveStringName()}~{_bonus}~{_target}~{_amountCompleted}";
        return saveString;
    }
}