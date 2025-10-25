namespace DesignPatters.Models.AdditionalLectures;

public class AgeChangedEvent : CEvent
{
    public CPerson Target { get; set; }
    public int OldValue { get; set; }
    public int NewValue { get; set; }
    
    public AgeChangedEvent(CPerson target, int oldValue, int newValue)
    {
        Target = target;
        OldValue = oldValue;
        NewValue = newValue;
    }
    
    public override string ToString()
    {
        return $"Age Changed from {OldValue} to {NewValue}";
    }
}