namespace DesignPatters.Models.Reporting;

public class ReportingServiceWithLogging : IReportingService
{
    private readonly IReportingService _reportingService;

    public ReportingServiceWithLogging(IReportingService reportingService)
    {
        _reportingService = reportingService;
    }

    public void Report()
    {
        Console.WriteLine("Starting the logs...");
        _reportingService.Report();
        Console.WriteLine("Finishing the logs...");
    }
}