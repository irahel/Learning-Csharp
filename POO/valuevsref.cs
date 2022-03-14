
static void TestSomeReference()
{
    SomeReference rt = new();
    rt.value = 12;

    Console.WriteLine(rt);
    AcessByRef(rt);
    Console.WriteLine(rt);

}

static void AcessByRef(SomeReference sr)
{
    sr.value = 42;
}

public class SomeReference
{
    public int value{ get; set; }
    public override string ToString()
    {
        return value.ToString();
    }
}
