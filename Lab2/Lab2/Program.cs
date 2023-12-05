using System;

public abstract class GeometricFigure
{
    // Виртуальный метод для вычисления площади фигуры
    public abstract double CalculateArea();

    public override string ToString()
    {
        return $"Площадь фигуры: {CalculateArea()}";
    }
}

public class Rectangle : GeometricFigure
{
    // Ширина и высота объявляются как свойства
    public double Width { get; set; }
    public double Height { get; set; }

    // Конструктор по параметрам «ширина» и «высота»
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }

    public void Print()
    {
        Console.WriteLine($"Прямоугольник: Ширина = {Width}, Высота = {Height}. {ToString()}");
    }
}

public class Square : Rectangle
{
    //  Конструктор по длине стороны
    public Square(double side) : base(side, side)
    {
    }

    public new void Print()
    {
        Console.WriteLine($"Квадрат: Сторона = {Width}. {ToString()}");
    }
}

public class Circle : GeometricFigure
{
    // Радиус объявляется как свойство
    public double Radius { get; set; }

    // Конструктор по параметру «радиус»
    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public void Print()
    {
        Console.WriteLine($"Круг: Радиус = {Radius}. {ToString()}");
    }
}

public interface IPrint
{
    void Print();
}

class Program
{
    static void Main()
    {
        Rectangle rectangle = new Rectangle(5, 10);
        Square square = new Square(7);
        Circle circle = new Circle(3);

        rectangle.Print();
        square.Print();
        circle.Print();
    }
}