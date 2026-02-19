class Running: Activity
{
    private double _distance;
    public Running(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }
    public override string GetSummary()
    {
        double speed = _distance / _length * 60.0;
        double pace = _length / _distance;
        string getSummary = $"Running: {base.GetSummary()} - Distance: {_distance} miles - Speed: {speed} mph - Pace: {Math.Round(pace,1)} min per mile";
        return getSummary;
    }
}