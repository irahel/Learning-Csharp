class SomeClass
{
    private const int DEFAULT_PROPERTY_INT = 42;
    public int SomeProperty { get; set; }
    ~SomClass()
    {
        Console.WriteLine("The Class was finalized");
        destroy(SomeProperty);
    }
}