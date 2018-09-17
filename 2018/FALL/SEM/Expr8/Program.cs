using System;

namespace CS
{
    /// <summary>
    /// Finding coordinates of restraint of two straight lines
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write coordinates of point: ");
            Console.WriteLine("x1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write coefficients of straight line: ");
            Console.WriteLine("k:");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b:");
            int b = Convert.ToInt32(Console.ReadLine());
            


            double newK = -1 / Math.Tan(Math.Atan(k));
            double newB = y1 - newK * x1;
            double x0 = (b - newB) / (newK - k);
            double y0 = k * x0 + b;

            Console.WriteLine("The coordinates of restraint: (" + x0 + ';' + y0 + ')');
            Console.ReadKey();
        }
    }
}
