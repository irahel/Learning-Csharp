int a = 5;
int b = 9;

//One line conditionals
if (a+b > 10)   Console.WriteLine("> 10");
else Console.WriteLine("< 10");

if(a+b > 10)
{
    Console.WriteLine("Greater than 10");
    Console.WriteLine("The result is:");
    Console.WriteLine($"\t{a} + {b} = {a+b}");
}
else
{
    Console.WriteLine("Less than 10");
    Console.WriteLine("The result is:");
    Console.WriteLine($"\t{a} + {b} = {a+b}");
}

if (a > 10 || b > 10)   Console.WriteLine($"{a} or {b} is greater than 10");
else Console.WriteLine($"{a} and {b} are less than 10");