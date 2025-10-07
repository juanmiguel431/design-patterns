namespace DesignPatters.Models.MethodChain;

public class Query
{
    public string CreatureName { get; set; }
    public Argument WhatToQuery { get; set; }
    public int Value { get; set; }

    public Query(string creatureName, Argument whatToQuery, int value)
    {
        CreatureName = creatureName ?? throw new ArgumentNullException(nameof(creatureName));
        WhatToQuery = whatToQuery;
        Value = value;
    }

    public enum Argument
    {
        Attack, Defence,
    }
}