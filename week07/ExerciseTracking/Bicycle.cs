class Bicycle : Activity
{
    private double _distance;
    public Bicycle(string date, int length, double distance) :base(date, length)
    {
        _distance = distance;
    }
    public override string GetSummary()
    {
        double speed = _distance / _length * 60.0;
        double pace = _length / _distance;
        string getSummary = $"Bicycling: {base.GetSummary()} - Distance: {_distance} miles - Speed: {Math.Round(speed, 1)} mph - Pace: {pace} min per mile";
        return getSummary;
    }
}