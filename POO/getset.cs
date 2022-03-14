public class CalendarEntry
{
    private DateTime _date;
    public void setDate(string date)
    {
        DateTime dt = Convert.ToDateTime(date);
        if(dt.year > 1900 && dt.year <= DateTime.Today.Year)    _date = dt;
        else throw new ArgumentOutOfRangeException("Date out of range");
    }
    public string getDate()
    {
        return _date.toString();
    }
}