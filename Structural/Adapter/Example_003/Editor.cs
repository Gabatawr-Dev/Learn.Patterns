namespace Patterns.Structural.Adapter.Example_003;

public class Editor
{
    public IEnumerable<Button> Buttons { get; }

    public Editor(IEnumerable<Button> buttons) => 
        Buttons = buttons;

    public void ClickAll()
    {
        foreach (var btn in Buttons)
            btn.Click();
    }
}