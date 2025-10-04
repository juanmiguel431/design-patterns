namespace DesignPatters.Models.Reporting;

public class ReportingService : IReportingService
{
    public void Report()
    {
        Console.WriteLine("Here is your report.");
    }
}