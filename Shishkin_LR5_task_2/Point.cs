using System;
namespace PointApp
{
    class Point
    {
        public double X;
        public double Y;
        public void Read()
        {
            Console.Write("X = ");
            X = double.Parse(Console.ReadLine());
            Console.Write("Y = ");
            Y = double.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine($"Точка: X={X}, Y={Y}");
        }
        public void MoveX(double step)
        {
            X += step;
        }
        public void MoveY(double step)
        {
            Y += step;
        }
        public double DistanceToOrigin()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public double DistanceTo(Point other)
        {
            double dx = X - other.X;
            double dy = Y - other.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}