namespace DesignPatters.Models.Proxy;

public class MasonrySettings
{
    public bool? All
    {
        get
        {
            if (Pillars && Walls && Floors) return Pillars;
            return null;
        }
        set
        {
            if (!value.HasValue) return;
            Pillars = Walls = Floors = value.Value;
        }
    }
    
    
    public bool Pillars { get; set; }
    public bool Walls { get; set; }
    public bool Floors { get; set; }
}