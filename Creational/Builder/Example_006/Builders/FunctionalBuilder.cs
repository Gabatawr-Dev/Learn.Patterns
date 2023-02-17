namespace Patterns.Creational.Builder.Example_006.Builders;

public abstract class FunctionalBuilder<TSubject, TSelf>
    where TSelf : FunctionalBuilder<TSubject, TSelf>
    where TSubject : new()
{
    private readonly List<Func<TSubject, TSubject>> _actions = new ();

    public TSelf Do(Action<TSubject> action) =>
        AddAction(action);

    private TSelf AddAction(Action<TSubject> action)
    {
        _actions.Add(p => { action(p); return p; });
        return (TSelf)this;
    }

    public TSubject Build() => _actions
        .Aggregate(new TSubject(), (p, f) => f(p));
}