using System;

delegate void CustomDel(string s);

class TestClass
{
    static void Hello(string s)
    {
        Console.WriteLine($"Hello, {s}");
    }
    static void Goodbye(string s)
    {
        Console.WriteLine($"Goodbye, {s}");
    }

    static void Main()
    {
        CustomDel hiDel, byeDel, multiDel, multiMinusHiDel;

        hiDel = Hello;
        byeDel = Goodbye;
        multiDel = hiDel + byeDel;
        multiMinusHiDel = multiDel - hiDel;

        hiDel("A");
        byeDel("B");
        multiDel("C");
        multiMinusHiDel("D");

    }
}