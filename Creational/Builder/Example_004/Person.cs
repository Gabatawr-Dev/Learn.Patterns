using System.Text;

namespace Patterns.Creational.Builder.Example_004;

public class Person
{
    public string? StreetAddress, Postcode, City;

    public string? CompanyName, Position;

    public int AnnualIncome;

    public override string ToString()
    {
        var sb = new StringBuilder();
        const int pr = 14;

        sb.AppendLine($"{nameof(StreetAddress).PadRight(pr)}: {StreetAddress}");
        sb.AppendLine($"{nameof(Postcode).PadRight(pr)}: {Postcode}");
        sb.AppendLine($"{nameof(City).PadRight(pr)}: {City}");
        sb.AppendLine($"{nameof(CompanyName).PadRight(pr)}: {CompanyName}");
        sb.AppendLine($"{nameof(Position).PadRight(pr)}: {Position}");
        sb.AppendLine($"{nameof(AnnualIncome).PadRight(pr)}: {AnnualIncome}");

        return sb.ToString();
    }
}