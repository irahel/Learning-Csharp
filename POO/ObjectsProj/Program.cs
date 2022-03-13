public class Person
{
    public string Name { get; set; }
    public int? Age { get; set; }
    
    public Person()
    {
        Name = "unkown";
        Age = null;
    }
    public Person(string name, int? age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString() => $"My name is {Name}";    
    
}

class Program
{
    static void Main()
    {
        Person p1 = new Person("Rahel", 24);
        Console.WriteLine(p1);

        //C# > 10
        Person p2 = new ("Caetano", 27);
        p2.Age = 26;
        Console.WriteLine(p2);
        
        Console.WriteLine(p1 == p2);        
    }
}