namespace DesignPatters.Models.StatePattern;

public enum CallState
{
    OffHook, Connecting, Connected, OnHold,
}

public enum Trigger
{
    CallDialed, HungUp, CallConnected, PlaceOnHold, TakenOffHold, LeftMessage,
}

class PhoneStateMachine
{
    private static Dictionary<CallState, List<(Trigger, CallState)>> _rules = new()
    {
        [CallState.OffHook] = new List<(Trigger, CallState)>()
        {
            (Trigger.CallDialed, CallState.Connecting),
        },
        [CallState.Connecting] = new List<(Trigger, CallState)>()
        {
            (Trigger.HungUp, CallState.OffHook),
            (Trigger.CallConnected, CallState.Connected),
        },
        [CallState.Connected] = new List<(Trigger, CallState)>()
        {
            (Trigger.LeftMessage, CallState.OffHook),
            (Trigger.HungUp, CallState.OffHook),
            (Trigger.PlaceOnHold, CallState.OnHold),
        },
        [CallState.OnHold] = new List<(Trigger, CallState)>()
        {
            (Trigger.TakenOffHold, CallState.Connected),
            (Trigger.HungUp, CallState.OffHook),
        },
    };

    public static void Run()
    {
        var state = CallState.OffHook;
        while (true)
        {
            Console.WriteLine($"The phone is currently {state}");
            Console.WriteLine("Select a trigger:");

            for (int i = 0; i < _rules[state].Count; i++)
            {
                var (t, _) = _rules[state][i];
                Console.WriteLine($"{i}. {t}");
            }

            var input = int.Parse(Console.ReadLine());
            
            var (_, s) = _rules[state][input];
            state = s;
        }
    }
}