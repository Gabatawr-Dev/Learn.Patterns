namespace Patterns.Structural.Bridge.Example_001.Outputs;

public class PdfOutput : AbstractOutput
{
    public PdfOutput() => Extension = "PDF";
}