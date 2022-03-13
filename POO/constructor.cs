class SomeClass
{
    private const int DEFAULT_PROPERTY_INT = 42;
    public int SomeProperty { get; set; }
    public SomeClass()
    {
        SomeProperty = DEFAULT_PROPERTY_INT;
    }
    
    public SomeClass(int propertyChanged)
    {
        SomeProperty = propertyChanged;
    }
}