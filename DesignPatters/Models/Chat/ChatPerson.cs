namespace DesignPatters.Models.Chat;

public class ChatPerson
{
    public string Name { get; set; }
    public ChatRoom Room { get; set; }
    private List<string> _chatLog = new();

    public ChatPerson(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }
    
    public void Say(string message)
    {
        Room.Broadcast(Name, message);
    }
    
    public void PrivateMessage(string who, string message)
    {
        Room.Message(Name, who, message);
    }

    public void Receive(string sender, string message)
    {
        var log = $"{sender}: '{message}'";
        _chatLog.Add(log);
        Console.WriteLine($"[{Name}' chat session] {log}");
    }
}