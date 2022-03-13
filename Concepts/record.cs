static void Main()
{
    Person person1 = new("Rahel", "Oliveira");
    Person person2 = new("Lavinia", "Morais");
    Console.WriteLine(person1);    

    var phoneNumbers = new string?[2];

    Phone phone2 = new(person1, phoneNumbers);
    Phone phone2 = new(person2, phoneNumbers);

    Console.WriteLine(phone1 == phone2);
    phoneNumbers[0] = "5555-5555";
    phoneNumbers[0] = "6666-6666";
    Console.WriteLine(phone1 == phone2);

    //Copying imutable record
    //changing name
    Person person3 = person1 with {firstName = "Caetano"};
    Console.WriteLine(person1 == person3);

    //Not changing
    Person person4 = person1 with {};
    Console.WriteLine(person1 == person4);

}
public record Person(string FirstName, string LastName);
public record Phone(Person PersonRef, string[] PhoneNumbers);