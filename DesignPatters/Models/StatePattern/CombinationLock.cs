namespace DesignPatters.Models.StatePattern;

public class CombinationLock
{
    private readonly string _combinationString;

    public CombinationLock(int [] combination)
    {
        _combinationString = string.Join("", combination);
        Status = "LOCKED";
    }

    // you need to be changing this on user input
    public string Status; // LOCKED, OPEN, ERROR

    public override string ToString()
    {
        return Status;
    }

    public void EnterDigit(int digit)
    {
        switch (Status)
        {
            case "LOCKED":
                Status = digit.ToString();
                break;
            case "OPEN":
                break;
            case "ERROR":
                break;
            default:
                Status += digit;
                
                if (_combinationString == Status)
                {
                    Status = "OPEN";
                    break;
                }

                if (Status.Length >= _combinationString.Length)
                {
                    Status = "ERROR";
                    break;
                }
                
                break;
        }
    }
}


// State Coding Exercise
//     A combination lock is a lock that opens after the right digits have been entered. A lock is preprogrammed with a combination (e.g., 12345 )
// and the user is expected to enter this combination to unlock the lock.
//
// The lock has a Status field that indicates the state of the lock. The rules are:
//
// If the lock has just been locked (or at startup), the status is LOCKED.
//     If a digit has been entered, that digit is shown on the screen. As the user enters more digits, they are added to Status.
//     If the user has entered the correct sequence of digits, the lock status changes to OPEN.
//     If the user enters an incorrect sequence of digits, the lock status changes to ERROR.
//     Please implement the CombinationLock  class to enable this behavior. Be sure to test both correct and incorrect inputs.
//
// Here is an example unit test for the lock:
//
// var cl = new CombinationLock(new[] {1, 2, 3, 4, 5});
// Assert.That(cl.Status, Is.EqualTo("LOCKED"));
// cl.EnterDigit(1);
// Assert.That(cl.Status, Is.EqualTo("1"));
// cl.EnterDigit(2);
// Assert.That(cl.Status, Is.EqualTo("12"));
// cl.EnterDigit(3);
// Assert.That(cl.Status, Is.EqualTo("123"));
// cl.EnterDigit(4);
// Assert.That(cl.Status, Is.EqualTo("1234"));
// cl.EnterDigit(5);
// Assert.That(cl.Status, Is.EqualTo("OPEN"));