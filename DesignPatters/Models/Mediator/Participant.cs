namespace DesignPatters.Models.Mediator;

public class Participant
{
    private readonly SampleMediator _mediator;
    public int Value { get; set; }

    public Participant(SampleMediator mediator)
    {
        _mediator = mediator;
        mediator.Register(this);
    }

    public void Say(int n)
    {
        _mediator.Publish(this, n);
    }
}


// Our system has any number of instances of Participant  classes. Each Participant has a Value integer, initially zero.
//
//     A participant can Say()  a particular value, which is broadcast to all other participants. At this point in time, every other participant is obliged to increase their Value  by the value being broadcast.
//
//     Example:
//
// Two participants start with values 0 and 0 respectively
//     Participant 1 broadcasts the value 3. We now have Participant 1 value = 0, Participant 2 value = 3
// Participant 2 broadcasts the value 2. We now have Participant 1 value = 2, Participant 2 value = 3