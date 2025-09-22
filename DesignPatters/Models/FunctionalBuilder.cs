namespace DesignPatters.Models;

public abstract class FunctionalBuilder<TSelf, TEntity>
    where TSelf : FunctionalBuilder<TSelf, TEntity>
    where TEntity : new()
{
    private readonly List<Func<TEntity, TEntity>> _actions = [];
    
    public TSelf Do(Action<TEntity> action) => AddAction(action);

    public TEntity Build()
    {
        return _actions.Aggregate(new TEntity(), (person, action) => action(person));
    }
    
    private TSelf AddAction(Action<TEntity> action)
    {
        _actions.Add(person =>
        {
            action(person);
            return person;
        });
        
        return (TSelf) this;
    }
}