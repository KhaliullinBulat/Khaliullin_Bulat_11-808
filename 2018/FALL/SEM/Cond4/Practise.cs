using System;
namespace Slide01
{
    /// <summary>
    /// Khaliullin Bulat
    /// Cond4
    /// Finding intersection of two segments
    /// </summary>
    class Program
    {
        static void Main()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Min(B, D) - Math.Max(A, C));

            Console.ReadKey();
        }
    }
}