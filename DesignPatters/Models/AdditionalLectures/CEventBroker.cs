namespace DesignPatters.Models.AdditionalLectures;

public class CEventBroker
{
    // 1. All events that happened.
    public IList<CEvent> AllEvents = [];
    
    // 2. Commands
    public event EventHandler<CCommand>? Command;
    // 3. Query
    public event EventHandler<CQuery>? Query;
    
    public void ExecuteCommand(CCommand e)
    {
        Command?.Invoke(this, e);
    }
    
    public T ExecuteQuery<T>(CQuery query)
    {
        Query?.Invoke(this, query);
        return (T)query.Result;
    }
}