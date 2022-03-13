var names = new List<string>{"Rahel", "Isaac", "Lavinia"};

foreach (string name in names) Console.WriteLine($"Hello {name}");

names.Add("Caetano");
names.Add("Igor");
names.Remove("Rahel");

foreach (string name in names) Console.WriteLine($"Hello {name}");

int index = 3;
Console.WriteLine($"In index {index} we have {names[index]}");
Console.WriteLine($"The list has {names.Count} people in it");

index = names.IndexOf("Isaac");

if (index == -1) Console.WriteLine("Name not found");
else Console.WriteLine($"isaac was in index {index}");