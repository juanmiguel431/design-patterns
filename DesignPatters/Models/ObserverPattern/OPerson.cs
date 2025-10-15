namespace DesignPatters.Models.ObserverPattern;

public class OPerson
{
    public event EventHandler<FallsIllEventArgs>? FallsIll;

    public void CatchCold()
    {
        FallsIll?.Invoke(this, new FallsIllEventArgs
        {
            Address = "123 London Road"
        });
    }
}