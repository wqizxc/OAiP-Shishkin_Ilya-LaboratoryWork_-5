using System;
using System.Drawing;
namespace PointApp
{
    class Program
    {
        static void Main()
        {
            Point p1 = new Point();
            Point p2 = new Point();
            Console.WriteLine("Первая точка:");
            p1.Read();
            Console.WriteLine("\nВторая точка:");
            p2.Read();
            Console.WriteLine("\nИсходные точки");
            p1.Display();
            p2.Display();
            Console.WriteLine("\nСдвиг первой точки");
            Console.Write("Сдвиг по X: ");
            double moveX1 = double.Parse(Console.ReadLine());
            p1.MoveX(moveX1);
            Console.Write("Сдвиг по Y: ");
            double moveY1 = double.Parse(Console.ReadLine());
            p1.MoveY(moveY1);
            Console.WriteLine("\nСдвиг второй точки");
            Console.Write("Сдвиг по X: ");
            double moveX2 = double.Parse(Console.ReadLine());
            p2.MoveX(moveX2);
            Console.Write("Сдвиг по Y: ");
            double moveY2 = double.Parse(Console.ReadLine());
            p2.MoveY(moveY2);
            Console.WriteLine("\nРезультаты");
            p1.Display();
            Console.WriteLine($"Расстояние до (0,0): {p1.DistanceToOrigin():F2}");
            p2.Display();
            Console.WriteLine($"Расстояние до (0,0): {p2.DistanceToOrigin():F2}");
            Console.WriteLine($"\nРасстояние между точками: {p1.DistanceTo(p2):F2}");
        }
    }
}