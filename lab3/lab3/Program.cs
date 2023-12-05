// Интерфейс IComparable
interface IComparable
{
    double GetArea();
}

// Базовый класс "Геометрическая фигура"
class Figure : IComparable, IComparer<Figure>
{
    public virtual double GetArea()
    {
        return 0.0;
    }

    public int CompareTo(object obj)
    {
        Figure other = obj as Figure;
        if (other == null)
            throw new ArgumentException("Object is not a Figure");

        return this.GetArea().CompareTo(other.GetArea());
    }

    public int Compare(Figure x, Figure y)
    {
        return x.GetArea().CompareTo(y.GetArea());
    }
}

// Производные классы: Прямоугольник, Квадрат, Круг
class Rectangle : Figure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double GetArea()
    {
        return Width * Height;
    }
}

class Square : Figure
{
    public double Side { get; set; }

    public override double GetArea()
    {
        return Side * Side;
    }
}

class Circle : Figure
{
    public double Radius { get; set; }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Figure> figureList = new List<Figure>
        {
            new Rectangle { Width = 6, Height = 8 },
            new Square { Side = 4 },
            new Circle { Radius = 3.0 }
        };

        figureList.Sort(new Figure());
        Console.WriteLine("\nList<Figure> sorted by area:");
        PrintCollection(figureList);
    }

    // Вывод элементов коллекции
    static void PrintCollection(List<Figure> collection)
    {
        foreach (var item in collection)
        {
            Console.WriteLine($"Figure: {item.GetType().Name}, Area: {((Figure)item).GetArea()}");
        }
    }
}