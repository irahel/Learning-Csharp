class SampleCollection<T>
{
    private T[] arr = new T[100];
    public T this[int index]
    {
        get => arr[index];
        set => arr[index] = value;
    }
}

class Program
{
   static void Main()
   {
      var stringCollection = new SampleCollection<string>();
      stringCollection[0] = "Hello, World";
      Console.WriteLine(stringCollection[0]);
   }
}