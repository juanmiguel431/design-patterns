namespace DesignPatters.Models.AdditionalLectures;

public class ChangeAgeCommand : CCommand
{
    public CPerson Target { get; set; }
    public int Age { get; set; }
    
    public ChangeAgeCommand(CPerson target, int age)
    {
        Target = target;
        Age = age;
    }
}