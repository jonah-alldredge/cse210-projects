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
    public virtual void RecordEvent()
    {
        
    }
    public virtual bool IsComplete()
    {
        return true;
    }
    public virtual string GetDetailString()
    {
        return "";
    }
    public virtual string GetStringRepresentation()
    {
        return "";
    }
}