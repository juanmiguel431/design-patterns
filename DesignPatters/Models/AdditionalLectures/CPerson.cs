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