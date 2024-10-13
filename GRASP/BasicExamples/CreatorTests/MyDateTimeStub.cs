using Creator;
using System.Text.RegularExpressions;

namespace BookTests;




public class MyDateTimeStub : IDateTime
{
    private DateTime _currentDay;

    public MyDateTimeStub()
    {
        _currentDay = DateTime.Today;
    }

    public MyDateTimeStub(string date)
    {
        if (IsValidDate(date))
        {
            _currentDay = DateTime.Parse(date);
        }
        else
        {
            throw new ArgumentException("Invalid date format");
        }
    }

    public DateTime Date
    {
        get { return _currentDay; }
    }

    private bool IsValidDate(string date)
    {
        return DateTime.TryParse(date, out _);
    }
}