namespace DesignPatters.Models.StatePattern;

public enum Health
{
    NonReproductive, Pregnant, Reproductive
}

public enum HealthActivity
{
    GiveBirth,
    ReachPuberty,
    HaveAbortion,
    HaveUnprotectedSex,
    Hysterectomy
}

public class HealthDemo
{
    public static bool ParentsNotWatching()
    {
        return true;
    }
}