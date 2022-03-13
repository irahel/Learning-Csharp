interface IEquatable<T>
{
    bool Equals(T other);
}

public class Car : IEquatable<Car>
{
    public string? Make {get; set; }
    public string? Model {get; set; }
    public string? Year {get; set; }

    public Car(string make, string model, string year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public bool Equals(Car? other)
    {
        return (this.Model == other.Model && this.Year == other.Year);
    }
}