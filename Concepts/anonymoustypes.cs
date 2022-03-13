var v = new {Amount = 35, Message = "Hello"};

Console.WriteLine(v.Amount);
Console.WriteLine(v.Message);

var v2 = v with {Message = "World"};

Console.WriteLine(v2.Amount);
Console.WriteLine(v2.Message);

