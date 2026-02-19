class Swimming : Activity
{
    private int _numberOfLaps;
    public Swimming(string date, int length, int numberOfLaps) : base(date, length)
    {
        _numberOfLaps = numberOfLaps;
    }
    public override string GetSummary()
    {
        double distance = _numberOfLaps * 50.0 / 1000.0 * 0.62;
        double speed = distance / _length * 60.0;
        double pace = _length / distance;
        string getSummary = $"Bicycling: {base.GetSummary()} - Distance: {distance} miles - Speed: {speed} mph - Pace: {Math.Round(pace, 1)} min per mile";
        return getSummary;
    }
}