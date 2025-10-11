namespace DesignPatters.Models.Iterator;

public class BinaryTree<T>
{
    public Node<T> Root { get; set; }
    public BinaryTree(Node<T> root)
    {
        Root = root;
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

            foreach (var node in Traverse(Root))
            {
                yield return node;
            }
        }
    } 
}