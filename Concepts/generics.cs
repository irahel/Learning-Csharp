public class GenericList<T>
{
    public void Add(T item){}
}
private class SomeClass{}
public class TestGenericList
{
    static void Main()
    {
        GenericList<int> listInt = new();
        listInt.Add(321);

        GenericList<string> listString = new();
        listString.Add("teste");

        GenericList<SomeClass> listClass = new();
        listClass.Add(new SomeClass());
    }
}