namespace DesignPatters.Models.Iterator;

public class InOrderIterator<T>
{
    private readonly Node<T> _root;
    public Node<T> Current { get; set; }
    private bool _yieldedStart;

    public InOrderIterator(Node<T> root)
    {
        _root = root;
        Current = root;
        while (Current.Left is not null)
        {
            Current = Current.Left;
        }
    }
    
    public bool MoveNext()
    {
        if (!_yieldedStart)
        {
            _yieldedStart = true;
            return true;
        }

        if (Current.Right is not null)
        {
            Current = Current.Right;
            while (Current.Left is not null)
            {
                Current = Current.Left;
            }
            
            return true;
        }

        var parent = Current.Parent;
        while (parent is not null && Current == parent.Right)
        {
            Current = parent;
            parent = parent.Parent;
        }
            
        Current = parent;
        return Current is not null;
    }
    
    public void Reset()
    {
        Current = _root;
        _yieldedStart = false;
    }
}