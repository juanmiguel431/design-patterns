namespace DesignPatters.Models.Iterator;

public class Node<T>
{
    public T Value { get; set; }
    public Node<T>? Left { get; set; }
    public Node<T>? Right { get; set; }
    public Node<T>? Parent { get; set; }

    public Node(T value)
    {
        Value = value;
    }

    public Node(T value, Node<T> left, Node<T> right)
    {
        Value = value;
        Left = left;
        Right = right;
        
        left.Parent = right.Parent = this;
    }
    
    public IEnumerable<T> PreOrder
    {
        get
        {
            IEnumerable<Node<T>> Traverse(Node<T> current)
            {
                yield return current;

                if (current.Left is not null)
                {
                    foreach (var left in Traverse(current.Left)) 
                        yield return left;
                }
                
                if (current.Right is not null)
                {
                    foreach (var right in Traverse(current.Right)) 
                        yield return right;
                }
            }

            foreach (var node in Traverse(this))
            {
                yield return node.Value;
            }
        }
    }
}