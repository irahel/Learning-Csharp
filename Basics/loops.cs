//While
int counter = 0;
while (counter < 100)
{
    Console.WriteLine($"Hello, my counter is {counter}");
    counter++;
}

counter = 0;
do
{
    Console.WriteLine($"Hello, my counter is {counter}");
    counter++; 
}while (counter < 100);

//for

for(int counter = 0; counter < 100; counter++)  Console.Writeline($"Hello, my counter is {counter}");


for(char c = 'a'; c <= 'z'; c++)
{
    Console.WriteLine("Hello");
    Console.WriteLine($"\t tMy char is {c}");
}