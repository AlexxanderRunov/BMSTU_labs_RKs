using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        double a, b, c;

        if (args.Length >= 3 &&
            double.TryParse(args[0], out a) &&
            double.TryParse(args[1], out b) &&
            double.TryParse(args[2], out c))
        {
            SolveAndPrintEquation(a, b, c);
        }
        else
        {
            do
            {
                Console.Write("Введите коэффициент A: ");
            } while (!double.TryParse(Console.ReadLine(), out a));

            do
            {
                Console.Write("Введите коэффициент B: ");
            } while (!double.TryParse(Console.ReadLine(), out b));

            do
            {
                Console.Write("Введите коэффициент C: ");
            } while (!double.TryParse(Console.ReadLine(), out c));

            SolveAndPrintEquation(a, b, c);
        }
    }

    static void SolveAndPrintEquation(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Уравнение имеет два корня: x1 = {root1}, x2 = {root2}");
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Уравнение имеет один корень: x = {root}");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Уравнение не имеет действительных корней");
        }

        Console.ResetColor();
    }
}


