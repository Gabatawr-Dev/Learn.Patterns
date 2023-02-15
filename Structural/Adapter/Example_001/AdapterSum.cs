namespace Patterns.Structural.Adapter.Example_001;

public class AdapterSum : ISumService<int>
{
    private readonly SumWithCoeff _sumWithCoeff;

    public AdapterSum() => _sumWithCoeff = new(0);

    public int Sum(int a, int b)
    {
        _sumWithCoeff.Sum(a, b, out var res);
        return res;
    }
}