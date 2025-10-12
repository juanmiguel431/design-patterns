namespace DesignPatters.Models.Chat;

public class ChatRoom
{
    private readonly List<ChatPerson> _people = new();
    
    public void Join(ChatPerson chatPerson)
    {
        var joinMsg = $"{chatPerson.Name} joins the chat";
        Broadcast("room", joinMsg);
        
        chatPerson.Room = this;
        _people.Add(chatPerson);
    }

    public void Broadcast(string source, string message)
    {
        foreach (var person in _people)
        {
            if (person.Name.Equals(source)) continue;
            
            person.Receive(source, message);
        }
    }
    
    public void Message(string source, string destination, string message)
    {
        var p = _people.FirstOrDefault(x => x.Name.Equals(destination));
        p?.Receive(source, message);
    }
}