int a = 10;
int b = 20;
int c = a + b;
Console.WriteLine($"{a} + {b} = {c}");
c = a - b;
c = a * b;
c = a / b;
c = a * (b + (a + b));
c = a % b;

int maximumInt = int.MaxValue;
int minimumInt = int.MinValue;

Console.WriteLine(maximumInt);
Console.WriteLine(minimumInt);

double a2 = 3.7;
Console.WriteLine(a2);

double maximumDouble = double.MaxValue;
double minimumDouble = double.MinValue;

Console.WriteLine(maximumDouble);
Console.WriteLine(minimumDouble);

double doublePrecisionInf = double.PositiveInfinity;
double doublePrecisionMinusInf = double.NegativeInfinity;

decimal decimalPrecision = 1.7;

decimal maximumDecimal = decimal.MaxValue;
decimal minimumDecimal = decimal.MinValue;

Console.WriteLine(maximumDecimal);
Console.WriteLine(minimumDecimal);

double radius = 2.5;
double area = Math.PI * Math.Pow(radius, 2);
Console.WriteLine(area);