using System;

namespace CS
{
    /// <summary>
    /// Expr13
    /// Khaliullin Bulat
    /// Finding the square of figure
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int r = Convert.ToInt32(Console.ReadLine());
            double square;

            if (r <= a / 2)
            {
                square = Math.PI * r * r;
            }
            else if (r >= a * Math.Sqrt(2) / 2)
            {
                square = a * a;
            }
            else
            {
                double x = Math.Sqrt(r * r - a * a / 4);
                double alpha = Math.Asin(x / r);
                double squareSektor = Math.PI * r * r * alpha * alpha / 360;
                double squareExcess = squareSektor - x * a / 2;
                square = Math.PI - 4 * squareExcess;
            }

            Console.WriteLine(square);
            Console.ReadKey();
        }
    }
}
