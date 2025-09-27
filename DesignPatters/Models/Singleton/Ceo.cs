﻿namespace DesignPatters.Models.Singleton;

public class Ceo
{
    private static string _name;
    private static int _age;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public int Age
    {
        get => _age;
        set => _age = value;
    }

    public Ceo(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Age)}: {Age}";
    }
}