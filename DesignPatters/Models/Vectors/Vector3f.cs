namespace DesignPatters.Models.Vectors;

public class Vector3f : VectorOfFloat<Vector3f, Dimensions.Three>
{
    public Vector3f()
    {
    }
    
    public Vector3f(params float[] values) : base(values)
    {
    }
}