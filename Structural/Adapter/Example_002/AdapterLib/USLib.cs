using Patterns.Structural.Adapter.Example_002.LegacyLib;

namespace Patterns.Structural.Adapter.Example_002.AdapterLib;

public class USLib : ILib
{
    private readonly UALib _uaLib;
    public USLib() => _uaLib = new();

    public int Sum(int a, int b) => _uaLib.Сумма(a, b);

    public int Div(int a, int b) => _uaLib.Різниця(a, b);

    public int Rem(int a, int b) => _uaLib.Залишок(a, b);
}