var fibonacciNumbers = new List<int> {1, 1};

int desiredFibonacciNumbers = 20;
while (fibonacciNumbers.Count < desiredFibonacciNumbers)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);    
}

Console.WriteLine($"The {fibonacciNumbers.Count}º is {fibonacciNumbers[fibonacciNumbers.Count -1]}");
Console.WriteLine($"The complete list is: ");

var countIndex = 1;
foreach (int number in fibonacciNumbers)
{
     Console.WriteLine($"{countIndex}º --> {number}");
     countIndex++;
}
