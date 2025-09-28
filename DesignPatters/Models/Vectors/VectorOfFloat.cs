namespace DesignPatters.Models.Vectors;

public class VectorOfFloat<TSelf, D> : Vector<TSelf, float, D>
    where D : IInteger, new()
    where TSelf : VectorOfFloat<TSelf, D>, new()
{
    public VectorOfFloat()
    {
    }

    public VectorOfFloat(params float[] values) : base(values)
    {
    }

    public static TSelf operator+(VectorOfFloat<TSelf, D> left, VectorOfFloat<TSelf, D> right)
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