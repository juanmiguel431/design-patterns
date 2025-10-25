namespace DesignPatters.Models.AdditionalLectures;

// CQRS - Command Query Responsibility Segregation
// CQS - Command Query Segregation

// Command = do/change

public class CPerson
{
    private int _age;
    private CEventBroker _broker;

    public CPerson(CEventBroker broker)
    {
        _broker = broker;
        _broker.Command += BrokerOnCommand;
        _broker.Query += BrokerOnQuery;
    }

    private void BrokerOnQuery(object? sender, CQuery e)
    {
        if (e is AgeQuery ageQuery)
        {
            if (ageQuery.Person == this)
            {
                e.Result = _age;
            }
        }
    }

    private void BrokerOnCommand(object? sender, CCommand? command)
    {
        if (command is ChangeAgeCommand ageCommand)
        {
            if (ageCommand.Target == this)
            {
                _age = ageCommand.Age;
            }
        }
    }
}

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

public class CQuery
{
    public object Result { get; set; }
}

public class AgeQuery : CQuery
{
    public CPerson Person { get; set; }
}

public class CCommand : EventArgs
{
    
}

public class ChangeAgeCommand : CCommand
{
    public CPerson Target { get; set; }
    public int Age { get; set; }
    
    public ChangeAgeCommand(CPerson target, int age)
    {
        Target = target;
        Age = age;
    }
}

public class CEvent
{
    // backtrack
}