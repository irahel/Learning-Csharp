Del handler = DelegateMethod;

handler("Hello World");
MethodWithCallback(10, 20, handler);

static void DelegateMethod(string msg)
{
    Console.WriteLine(msg);
}

static void MethodWithCallback(int param1, int param2, Del callback)
{
    callback($"The number is {param1 + param2}");
}

public delegate void Del(string msg);




