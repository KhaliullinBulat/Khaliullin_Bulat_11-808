using System;

namespace CS
{
    /// <summary>
    /// Calculate the distance from a point to a straight line given by two different points
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write coordinates of point: ");
            Console.WriteLine("x1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please write coordinates of straight: ");
            Console.WriteLine("x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x3:");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y3:");
            double y3 = Convert.ToDouble(Console.ReadLine());

            double length12 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double length23 = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            double length31 = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));

            double x = (length12*length12 + length23*length23 - length31*length31) / 2 / length23;

            double height = Math.Sqrt(length12 * length12 - x * x);

            Console.WriteLine(height);
            Console.ReadKey();
        }
    }
}
