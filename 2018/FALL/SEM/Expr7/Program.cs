using System;

namespace CS
{
    /// <summary>
    /// Finding parallel and perpendicular vectors to given
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int k = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A straight line parallel to given: y = " + k + " * x + " + (b+5));

            double newK = -1 / Math.Tan(Math.Atan(k));

            Console.WriteLine("A straight line perpendicular to given: y = " + newK + " * x + " + b);
        
            Console.ReadKey();
        }
    }
}
