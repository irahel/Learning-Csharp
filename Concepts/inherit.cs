public class Employee
{
    public Employee()
    {
        Name = "unknown";
    }
    public Employee(string name)
    {
        Name = name;
    }

    //Readonly property
    public string Name { get;}

    //Override methods
    public override string ToString()
    {
        return Name;
    }
}

public class Manager : Employee
{
    public override string ToString()
    {
        return $"Manager {Name}";
    }
}