using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace DesignPatters.Models.ObserverPattern;

public sealed class BidirectionalBinding : IDisposable
{
    private bool _disposed;

    public BidirectionalBinding(
        INotifyPropertyChanged first,
        INotifyPropertyChanged second,
        Expression<Func<object>> firstProperty,
        Expression<Func<object>> secondProperty)
    {
        if (first == null) throw new ArgumentNullException(nameof(first));
        if (second == null) throw new ArgumentNullException(nameof(second));
        if (firstProperty == null) throw new ArgumentNullException(nameof(firstProperty));
        if (secondProperty == null) throw new ArgumentNullException(nameof(secondProperty));

        if (firstProperty.Body is MemberExpression firstExpr && secondProperty.Body is MemberExpression secondExpr)
        {
            if (firstExpr.Member is PropertyInfo firstProp && secondExpr.Member is PropertyInfo secondProp)
            {
                first.PropertyChanged += (sender, args) =>
                {
                    if (!_disposed)
                    {
                        secondProp.SetValue(second, firstProp.GetValue(first));
                    }
                };
                
                second.PropertyChanged += (sender, args) =>
                {
                    if (!_disposed)
                    {
                        firstProp.SetValue(first, secondProp.GetValue(second));
                    }
                };
            }
        }
    }
    
    public void Dispose()
    {
        if (_disposed) return;
        
        _disposed = true;
    }
}