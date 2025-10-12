namespace DesignPatters.Models.Mediator.Chat;

public class ChatPerson
{
    public string Name { get; set; }

    private ChatRoom? _room;

    private List<string> _chatLog = new();

    public ChatPerson(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    public void SetRoom(ChatRoom room)
    {
        _room = room ?? throw new ArgumentNullException(nameof(room));
    }
    
    private ChatRoom EnsureRoom()
    {
        return _room ?? throw new InvalidOperationException("Room is not set");
    }
    
    public void Say(string message)
    {
        EnsureRoom().Broadcast(Name, message);
    }
    
    public void PrivateMessage(string who, string message)
    {
        EnsureRoom().Message(Name, who, message);
    }

    public void Receive(string sender, string message)
    {
        var log = $"{sender}: '{message}'";
        _chatLog.Add(log);
        Console.WriteLine($"[{Name}' chat session] {log}");
    }
}