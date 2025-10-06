using System.ComponentModel;

namespace DesignPatters.Models.Proxy;

public static class OperationImpl
{
    private static readonly Dictionary<Operation, char> OperationNames = new();
    
    static OperationImpl()
    {
        var type = typeof(Operation);
        foreach (var op in Enum.GetValues<Operation>())
        {
            var memInfo = type.GetMember(op.ToString());
            if (memInfo.Length > 0)
            {
                var attrs = memInfo[0].GetCustomAttributes(
                    typeof(DescriptionAttribute), false);
                
                if (attrs.Length > 0)
                {
                    var attr = (DescriptionAttribute)attrs[0];
                    OperationNames[op] = attr.Description[0];
                }
            }
        }
    }
    
    private static readonly Dictionary<Operation, Func<double, double, double>> Operations = new()
    {
        [Operation.Mul] = (x, y) => x * y,
        [Operation.Div] = (x, y) => x / y,
        [Operation.Add] = (x, y) => x + y,
        [Operation.Sub] = (x, y) => x - y,
    };
    
    public static double Call(this Operation operation, int x, int y)
    {
        return Operations[operation](x, y);
    }

    public static char Name(this Operation operation)
    {
        return OperationNames[operation];
    }
}