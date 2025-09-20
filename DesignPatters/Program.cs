
using System.Diagnostics;
using DesignPatters.Models;

namespace DesignPatters;

class Program
{
    static void Main(string[] args)
    {
        CreateAndOpenJournalFile();

        Console.WriteLine("End");
    }

    private static void CreateAndOpenJournalFile()
    {
        var journal = new Journal();
        journal.AddEntry("I cried today.");
        journal.AddEntry("I ate a banana.");
        
        var persistence = new Persistence();
        
        var tempPath = Path.GetTempPath();
        var fileName = tempPath + "journal.txt";
        persistence.SaveToFile(journal, fileName, true);

        var psi = new ProcessStartInfo
        {
            FileName = fileName,
            UseShellExecute = true
        };
        
        Process.Start(psi);
    }
}