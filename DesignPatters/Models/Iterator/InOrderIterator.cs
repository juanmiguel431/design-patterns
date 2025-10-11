using System.Collections;

namespace DesignPatters.Models.Iterator;

public class InOrderIterator<T>: IEnumerator<T>
{
    private readonly Node<T> _root;
    private Node<T> _current;
    private bool _started;
    
    public T Current
    {
        get
        {
            if (!_started || _current == null)
                throw new InvalidOperationException("Enumeration has not started or has already finished.");
            
            return _current.Value;
        }
    }

    object IEnumerator.Current => Current!;

    public InOrderIterator(Node<T> root)
    {
        _root = root;
        _current = root;
        while (_current.Left is not null)
        {
            _current = _current.Left;
        }
    }
    
    public bool MoveNext()
    {
        if (!_started)
        {
            _started = true;
            return true;
        }

        if (_current.Right is not null)
        {
            _current = _current.Right;
            while (_current.Left is not null)
            {
                _current = _current.Left;
            }
            
            return true;
        }

        var parent = _current.Parent;
        while (parent is not null && _current == parent.Right)
        {
            _current = parent;
            parent = parent.Parent;
        }
            
        _current = parent;
        return _current is not null;
    }
    
    public void Reset()
    {
        _current = _root;
        _started = false;
    }

    public void Dispose()
    {
    }
}