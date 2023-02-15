namespace Patterns.Structural.Adapter.Example_001;

public class SumWithCoeff
{
    public int Coeff { get; set; }
    public SumWithCoeff(int coeff) => Coeff = coeff;
    public void Sum(int a, int b, out int res) =>
        res = a + b + Coeff;
}