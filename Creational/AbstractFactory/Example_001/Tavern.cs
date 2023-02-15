using Patterns.Creational.AbstractFactory.Example_001.Interfaces;

namespace Patterns.Creational.AbstractFactory.Example_001;

public class Tavern
{
    #region Static

    private static void WriteNumber(int n, bool endl = false) =>
        Console.Write($" #{n, 2} | " + (endl ? '\n' : string.Empty));

    private static readonly int PERSONS_FOR_TABLE = 3;
    private static int TablesCount(int persons)
    {
        var tmp = (int)Math.Ceiling(persons / (decimal)PERSONS_FOR_TABLE);
        return tmp < 1 ? 1 : tmp;
    }

    #endregion Static

    internal class TavernFurniture
    {
        public bool IsFree { get; set; }
        public IFurniture Furniture { get; set; }

        public TavernFurniture(IFurniture furniture)
        {
            IsFree = true;
            Furniture = furniture;
        }
    }

    private readonly List<TavernFurniture> _furnitures = new();

    private readonly IFactory _factory;
    public Tavern(IFactory factory) =>
        _factory = factory;

    public void Snack(int persons)
    {
        Console.WriteLine($">> Snack for {persons} persons\n");
        var furnitures = Reserve(persons);
        var chairs = furnitures.OfType<IChair>().ToList();
        var tables = furnitures.OfType<ITable>().ToList();

        for (var i = 0; i < persons; i++)
        {
            var j = i + 1;
            WriteNumber(j);

            chairs[i].Sit();
            WriteNumber(j);

            var tableIndex = TablesCount(j) - 1;
            tables[tableIndex].Eat();
            WriteNumber(tableIndex + 1, true);
        }

        Free(furnitures);
        Console.WriteLine();
    }

    private List<IFurniture> Reserve(int persons)
    {
        var furnitures = new List<IFurniture>();
        furnitures.AddRange(GetFurnitures<IChair>(persons));
        furnitures.AddRange(GetFurnitures<ITable>(TablesCount(persons)));
        return furnitures;
    }

    private IEnumerable<IFurniture> GetFurnitures<T>(int count) where T : IFurniture
    {
        var getFreeFurniture = _furnitures
            .Where(f => f.IsFree
                        && f.Furniture.GetType().GetInterfaces().Any(i =>
                            i == typeof(T)))
            .Select(items =>
            {
                items.IsFree = false;
                return items.Furniture;
            });

        var furnitures = getFreeFurniture
            .Take(count)
            .ToList();

        var orderCount = count - furnitures.Count;
        if (orderCount != 0)
        {
            Console.WriteLine($"++ Order for {orderCount} {typeof(T).Name}\n");

            for (var i = 0; i < count - furnitures.Count; i++)
                _furnitures.Add(new TavernFurniture(typeof(T).Name switch
                {
                    nameof(IChair) => (T)_factory.CreateChair(),
                    nameof(ITable) => (T)_factory.CreateTable(),
                    _ => throw new NotSupportedException()
                }));

            furnitures = furnitures.Concat(getFreeFurniture.Take(orderCount))
                .ToList();
        }

        return furnitures;
    }

    private void Free(IEnumerable<IFurniture> furnitures)
    {
        foreach (var f in furnitures)
            _furnitures.Single(tf =>
                tf.Furniture == f).IsFree = true;
    }
}