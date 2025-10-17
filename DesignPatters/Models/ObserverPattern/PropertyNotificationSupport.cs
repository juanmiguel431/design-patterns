using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace DesignPatters.Models.ObserverPattern;

public class PropertyNotificationSupport : INotifyPropertyChanged
{
    // CanVote -> Age, Citizenship
    private readonly Dictionary<string, HashSet<string>> _affectedBy = new();
    
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        foreach (var affected in _affectedBy.Keys)
        {
            if (_affectedBy[affected].Contains(propertyName))
            {
                OnPropertyChanged(affected);
            }
        }
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    protected Func<T> Property<T>(string name, Expression<Func<T>> expr)
    {
        Console.WriteLine($"Creating computed property {name} for expression {expr}");

        var visitor = new MemberAccessVisitor(GetType());
        visitor.Visit(expr);

        if (visitor.PropertyNames.Any())
        {
            if (!_affectedBy.ContainsKey(name))
            {
                _affectedBy.Add(name, new HashSet<string>());

                foreach (var propName in visitor.PropertyNames)
                {
                    if (propName != name)
                    {
                        _affectedBy[name].Add(propName);
                    }
                }
            }
        }
        
        return expr.Compile();
    }

    private class MemberAccessVisitor : ExpressionVisitor
    {
        private readonly Type _declaringType;
        public IList<string> PropertyNames { get; } = new List<string>();

        public MemberAccessVisitor(Type declaringType)
        {
            _declaringType = declaringType;
        }

        [return: NotNullIfNotNull("node")]
        public override Expression? Visit(Expression? node)
        {
            if (node is not null && node.NodeType == ExpressionType.MemberAccess)
            {
                var memberExpr = (MemberExpression) node;
                if (memberExpr.Member.DeclaringType == _declaringType)
                {
                    PropertyNames.Add(memberExpr.Member.Name);
                }
            }
            
            return base.Visit(node);
        }
    }
}