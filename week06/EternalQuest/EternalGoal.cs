public class EternalGoal: Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {

    }
    public override string SaveStringName()
    {
        string saveString = $"EternalGoal:{base.SaveStringName()}";
        return saveString;
    }
}