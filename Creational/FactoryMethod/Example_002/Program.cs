using Patterns.Creational.FactoryMethod.Example_002.A;

namespace Patterns.Creational.FactoryMethod.Example_002;

internal class Program
{
    private static void Main(string[] args)
    {
        // Warning : Циклическая зависимость А0<>АN
        var a = A0.Create();
    }
}