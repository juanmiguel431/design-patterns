namespace DesignPatters.Models.Vectors;

public static class Dimensions
{
    public struct One : IInteger
    {
        public int Value => 1;
    }
    
    public struct Two : IInteger
    {
        public int Value => 2;
    }

    public struct Three : IInteger
    {
        public int Value => 3;
    }
}