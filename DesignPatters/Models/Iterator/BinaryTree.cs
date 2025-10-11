namespace DesignPatters.Models.Iterator;

public class BinaryTree<T>
{
    private readonly Node<T> _root;
    public BinaryTree(Node<T> root)
    {
        _root = root;
    }

    public InOrderIterator<T> GetEnumerator()
    {
        return new InOrderIterator<T>(_root);
    }

    public IEnumerable<Node<T>> InOrder
    {
        get
        {
            IEnumerable<Node<T>> Traverse(Node<T> current)
            {
                if (current.Left is not null)
                {
                    foreach (var left in Traverse(current.Left)) 
                        yield return left;
                }
                
                yield return current;
                
                if (current.Right is not null)
                {
                    foreach (var right in Traverse(current.Right)) 
                        yield return right;
                }
            }

            foreach (var node in Traverse(_root))
            {
                yield return node;
            }
        }
    } 
}