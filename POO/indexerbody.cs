class SampleCollection<T>
{
    private T[] _arr = new T[100];
    private int _nextIndex = 0;

    public T this[int index] => _arr[index];

    public void Add(T value)
    {
        if(_nextIndex >= _arr.Length) throw new IndexOutOfRangeException("The collection is full");
        else _arr[_nextIndex++] = value;
    }
}