public class SimpleGoal:Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
            
    }
    public override void RecordEvent() // Marks the goal as completed - Calls IsCompleted? and then says it is complete?
    {
        
    }
    public override bool IsComplete() // Returns if the goal is complete or not
    {
        if (_isComplete)
        {
            return true;
        }
        return false;
    }
    public override string GetStringRepresentation()
    {

        return "";
    }

}