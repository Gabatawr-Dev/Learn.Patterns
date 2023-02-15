namespace Patterns.Creational.Builder.Example_002.Phone;

public abstract class AbstractPhone
{
    public string? Data { get; set; }
    protected AbstractPhone() => Data = "Device: phone;\t";

    public void AppendData(string data) => Data += data;
}