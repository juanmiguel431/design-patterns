﻿namespace DesignPatters.Models.Strategy;

public interface IDiscriminantStrategy
{
    double CalculateDiscriminant(double a, double b, double c);
}