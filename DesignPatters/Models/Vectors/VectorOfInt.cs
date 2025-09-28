namespace DesignPatters.Models.Vectors;

public class VectorOfInt<TSelf, D> : Vector<VectorOfInt<TSelf, D>, int, D>
    where D : IInteger, new()
    where TSelf : VectorOfInt<TSelf, D>, new()
{
    public VectorOfInt()
    {
    }

    public VectorOfInt(params int[] values) : base(values)
    {
    }

    public static TSelf operator+(VectorOfInt<TSelf, D> left, VectorOfInt<TSelf, D> right)
    {
        var result = new TSelf();
        var dim = new D().Value;
        for (var i = 0; i < dim; i++)
        {
            result[i] = left[i] + right[i];
        }
        
        return result;
    }
}