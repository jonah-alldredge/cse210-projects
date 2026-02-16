public class EternalGoal: Goal
{
    public EternalGoal(string shortName, string description, int points):base(shortName, description, points)
    {
        
    }
    public void RecordEvent()
    {

    }
    public bool IsComplete()
    {
        return true;
    }
    public string GetStringRepresentation()
    {
        return "";
    }
}