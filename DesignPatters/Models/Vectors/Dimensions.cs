namespace DesignPatters.Models.Vectors;

public static class Dimensions
{
    public class One : IInteger
    {
        public int Value => 1;
    }
    
    public class Two : IInteger
    {
        public int Value => 2;
    }

    public class Three : IInteger
    {
        public int Value => 3;
    }
}