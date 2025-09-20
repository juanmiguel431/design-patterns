namespace DesignPatters.Models;

public class Square : Rectangle
{
    public override int Width
    {
        set
        {
            base.Width = value;
            base.Height = value;
        }
    }

    public override int Height
    {
        set
        {
            base.Height = value;
            base.Width = value;
        }
    }
}