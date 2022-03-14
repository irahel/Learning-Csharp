Del d1 = new Del(Notify);
Del d2 = Notify;
//Anonymous
Del d3 = delegate(string name)
{
    Console.WriteLine($"Notification received for: {name}");
};
Del d4 = name => {Console.WriteLine($"Notification received for: {name}");};

static void Notify(string name)
{
    Console.WriteLine($"Notification received for: {name}");
}

delegate void Del(string str);

