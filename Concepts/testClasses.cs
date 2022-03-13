Employee rahel = new Employee("Rahel");
Employee lavie = new Employee("Lavie");

Console.WriteLine(rahel);
Console.WriteLine(lavie);


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