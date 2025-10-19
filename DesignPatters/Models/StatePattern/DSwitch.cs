namespace DesignPatters.Models.StatePattern;

public class DSwitch
{
    public State State = new OffState();

    public void On()
    {
        State.On(this);
    }
    
    public void Off()
    {
        State.Off(this);
    }
}

public abstract class State
{
    public virtual void On(DSwitch sw)
    {
        Console.WriteLine("Light is already on.");
    }
    
    public virtual void Off(DSwitch sw)
    {
        Console.WriteLine("Light is already off.");
    }
}

public class OnState : State
{
    public OnState()
    {
        Console.WriteLine("Light turned on.");
    }

    public override void Off(DSwitch sw)
    {
        Console.WriteLine("Turning light off...");
        sw.State = new OffState();
    }
}

public class OffState : State
{
    public OffState()
    {
        Console.WriteLine("Light turned off.");
    }
    
    public override void On(DSwitch sw)
    {
        Console.WriteLine("Turning light on...");
        sw.State = new OnState();
    }
}