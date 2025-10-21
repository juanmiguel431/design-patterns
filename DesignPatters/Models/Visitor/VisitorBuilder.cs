namespace DesignPatters.Models.Visitor;

public class VisitorBuilder<T, TResult>
{
    public static readonly VisitorBuilder<T, TResult> New = new();
    private readonly Dictionary<Type, Func<IVisitor<T, TResult>, T, TResult>> _visitors = new();

    private Func<IVisitor<T, TResult>, T, TResult> _defaultVisitor;

    public VisitorBuilder<T, TResult> For<TNode>(Func<IVisitor<T, TResult>, TNode, TResult> visitor)
        where TNode : T
    {
        _visitors[typeof(TNode)] = (v, node) => visitor(v, (TNode)node);
        return this;
    }

    public VisitorBuilder<T, TResult> Default(Func<IVisitor<T, TResult>, T, TResult> visitor)
    {
        _defaultVisitor = visitor;
        return this;
    }
    
    public IVisitor<T, TResult> Build()
    {
        return new BuiltVisitor(_visitors, _defaultVisitor);
    }

    private class BuiltVisitor : IVisitor<T, TResult>
    {
        private readonly Dictionary<Type, Func<IVisitor<T, TResult>, T, TResult>> _visitors;
        
        private readonly Func<IVisitor<T, TResult>, T, TResult> _defaultVisitor;

        public BuiltVisitor(Dictionary<Type, Func<IVisitor<T, TResult>, T, TResult>> visitors, Func<IVisitor<T, TResult>, T, TResult> defaultVisitor)
        {
            // _visitors = visitors ?? throw new ArgumentNullException(nameof(visitors));
            // _defaultVisitor = defaultVisitor ?? throw new ArgumentNullException(nameof(defaultVisitor));
            
            _visitors = visitors;
            _defaultVisitor = defaultVisitor;
        }
        
        public TResult Visit(IVisitor<T, TResult> self, T node)
        {
            var type = node.GetType();
            if (_visitors.TryGetValue(type, out var visitorFunc))
            {
                return visitorFunc(self, node);
            }
            return _defaultVisitor(self, node);
        }

        public TResult Visit(T node)
        {
            return Visit(this, node);
        }
    } 
}