using System;
namespace Slide01
{
    /// <summary>
    /// Khaliullin Bulat
    /// Cond5
    /// Finding minimal and maximum time for driving through the way
    /// </summary>
    class Program
    {
        static void Main()
        {
            int L = int.Parse(Console.WriteLine());
            int K = int.Parse(Console.WriteLine());
            int H = int.Parse(Console.WriteLine());
            int amount = L / K;
            if (L % K == 0)
                Console.WriteLine("Minimal and maximum times are equal: " + amount * H);
            else
            {
                Console.WriteLine("Minimal time is " + amount * H);
                Console.Write("Maximum time is " + (amount * H + H));
            }
            Console.ReadKey();
        }
    }
}