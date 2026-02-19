class Activity
{
    protected int _length;
    protected string _date;
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    public virtual string GetSummary()
    {
        string getSummary = $"{_date}({_length} minutes)";
        return getSummary;
    }
}