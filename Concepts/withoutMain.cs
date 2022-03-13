using System.Text;

//C# > 9.0

StringBuilder builder = new StringBuilder();
builder.AppendLine("Hello");
builder.AppendLine("World");

Console.WriteLine(builder.ToString());