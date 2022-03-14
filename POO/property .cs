public class CalendarEntry
{
    private DateTime _date;
    public DateTime Date
    {
        get
        {
            return _date;
        }
        set
        {
            if (value.Year > 1900 && value.Year <= DateTime.Today.Year) _date = value;
            else throw new ArgumentOutOfRangeException("Date out of range");            
        }
    }
}