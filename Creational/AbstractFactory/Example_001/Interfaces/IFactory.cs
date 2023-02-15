namespace Patterns.Creational.AbstractFactory.Example_001.Interfaces;

public interface IFactory
{
    public IChair CreateChair();
    public ITable CreateTable();
}