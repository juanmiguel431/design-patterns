namespace DesignPatters.Models.Commands;

public class Editor
{
    private readonly IEnumerable<Button> _buttons;

    public IEnumerable<Button> Buttons => _buttons;

    public Editor(IEnumerable<Button> buttons)
    {
        _buttons = buttons ?? throw new ArgumentNullException(nameof(buttons));
    }
    
    public void ClickAll()
    {
        foreach (var button in _buttons)
        {
            button.Click();
        }
    }
}