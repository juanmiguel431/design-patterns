namespace DesignPatters.Models.Proxy;

public class TwoBitSet
{
    // 64 bits --> 32 values
    private readonly ulong _data;

    public TwoBitSet(ulong data)
    {
        _data = data;
    }
    
    public byte this[int index]
    {
        get
        {
            var shift = index << 1;
            var mask = 0b11UL << shift;
            
            var result = _data & mask;
            return (byte)(result >> shift);
        }
    }
}