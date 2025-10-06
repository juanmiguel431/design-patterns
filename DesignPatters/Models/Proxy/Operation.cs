using System.ComponentModel;

namespace DesignPatters.Models.Proxy;

public enum Operation : byte
{
    [Description("*")]
    Mul = 0,
    [Description("/")]
    Div = 1,
    [Description("+")]
    Add = 2,
    [Description("-")]
    Sub = 3,
}