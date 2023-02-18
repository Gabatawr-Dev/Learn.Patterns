using Autofac;
using Autofac.Features.Metadata;

namespace Patterns.Structural.Adapter.Example_003;

public class Program
{
    private static void Main()
    {
        using var container = InitDI();
        var editor = container.Resolve<Editor>();

        editor.ClickAll();
        foreach (var btn in editor.Buttons)
            btn.PrintMe();
    }

    private static IContainer InitDI()
    {
        var builder = new ContainerBuilder();

        builder.RegisterType<OpenCommand>()
            .As<ICommand>()
            .WithMetadata("Name", "Open");
        builder.RegisterType<SaveCommand>()
            .As<ICommand>()
            .WithMetadata("Name", "Save");

        builder.RegisterAdapter<Meta<ICommand>, Button>(cmd =>
            new Button(cmd.Value, (string)cmd.Metadata["Name"]!));

        builder.RegisterType<Editor>();

        return builder.Build();
    }
}
