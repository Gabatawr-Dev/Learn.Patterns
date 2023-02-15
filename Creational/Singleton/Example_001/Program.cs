namespace Patterns.Creational.Singleton.Example_001;

internal class Program
{
    // Fun
    static void Main(string[] args)
    {
        Logger.Write(0, 1.2d, 3.45m, "String message one!");

        Logger.Log[6, 7d, 8.9m]["String message two!"].WaitL();
        var message = new Message("Info");
        Logger.Log[message].EndL();
    }
}

/*
Logger created!
log(28.06.2022, 18:03:12)
{
  Logger created!
}
log(28.06.2022, 18:03:12)
{
  0
  1,2
  3,45
  String message one!
}
log(28.06.2022, 18:03:12)
{
  6
  7
  8,9
  String message two!
  Message: Info
}
*/