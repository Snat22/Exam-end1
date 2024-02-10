namespace Task5;

public class Stack<T>
{
    List<T> _list = new List<T>();

    public void Push(T item)
    {
        _list.Add(item);
    }

    public T Pop()
    {
       T end = _list.Last();
       _list.Remove(end);
       return end;


    }


    public T Peek()
    {
        if (_list.Count == null)
        {
            System.Console.WriteLine($"{_list}");
        }
        return _list.Last();
    }   
}
