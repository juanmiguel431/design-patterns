using System.Text;

namespace DesignPatters.Models.Proxy;

public class Problem
{
    private readonly List<int> _numbers;
    private readonly List<Operation> _operations;

    public Problem(IEnumerable<int> numbers, IEnumerable<Operation> operations)
    {
        _numbers = new List<int>(numbers);
        _operations = new List<Operation>(operations);
    }

    public int Eval()
    {
        var opGroups = new[]
        {
            new[] { Operation.Mul, Operation.Div },
            new[] { Operation.Add, Operation.Sub }
        };

        startAgain:
        foreach (var group in opGroups)
        {
            for (var idx = 0; idx < _operations.Count; idx++)
            {
                var op = _operations[idx];
                if (group.Contains(op))
                {
                    var result = op.Call(_numbers[idx], _numbers[idx + 1]);

                    // Assume all fractional results are wrong
                    if (result != (int) result) return int.MinValue;
                    
                    _numbers[idx] = (int) result;
                    _numbers.RemoveAt(idx + 1);
                    _operations.RemoveAt(idx);
                    
                    if (_numbers.Count == 1) return _numbers[0];
                    goto startAgain;
                }
            }
        }
        return _numbers[0];
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var i = 0;

        for (; i < _operations.Count; i++)
        {
            sb.Append(_numbers[i]);
            sb.Append(_operations[i].Name());
        }
        
        sb.Append(_numbers[i]);
        return sb.ToString();
    }
}