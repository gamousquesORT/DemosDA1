namespace Creator;

public class DateTimeWrapper : IDateTime
{
    private DateTime _currentDayTime = new DateTime();
    
    public DateTime Date
    {
        get { return _currentDayTime; }
    }
}