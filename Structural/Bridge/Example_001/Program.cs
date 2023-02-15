using Patterns.Structural.Bridge.Example_001.Outputs;
using Patterns.Structural.Bridge.Example_001.Reports;

namespace Patterns.Structural.Bridge.Example_001;

internal class Program
{
    static void Main(string[] args)
    {
        var yearXmp = new YearReport<XmlOutput>();
        yearXmp.Print();

        var dayReport = new DayReport
        {
            Output = new PdfOutput()
        };
        dayReport.Print();

        dayReport.Output = null;
        dayReport.Print();

        dayReport.Output = new XmlOutput();
        dayReport.Print();

        var monthWord = new MonthReport(new WordOutput());
        monthWord.Print();

        Console.ReadKey();
    }
}