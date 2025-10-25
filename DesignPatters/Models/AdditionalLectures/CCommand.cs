namespace DesignPatters.Models.AdditionalLectures;

public class CCommand : EventArgs
{
    public bool Register { get; set; } = true;
}