namespace Patterns.Structural.Adapter.Example_001;

public interface ISumService<T>
{
    T Sum(T a, T b);
}