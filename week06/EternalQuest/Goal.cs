public class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    public virtual int RecordEvent()
    {
        return _points;
    }
    public virtual bool IsComplete()
    {
        return false;
    }
    public virtual string GetDetailString()
    {
        return _shortName;
    }
    public virtual string GetStringRepresentation()
    {
        string isComplete = " ";
        if (IsComplete())
        {
            isComplete = "X";
        }
        string stringRepresentation = $"[{isComplete}] {_shortName} ({_description})";
        return stringRepresentation;
    }
    public virtual string SaveStringName()
    {
        string saveString = $"{_shortName}~{_description}~{_points}";
        return saveString;
    }
}