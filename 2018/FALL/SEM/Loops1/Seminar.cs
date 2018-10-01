using System;

namespace Practise
{
    /// <summary>
    /// Khaliullin Bulat
    /// Loops1
    /// Inverting of number
    /// </summary>
    static class Program
    {
        static void Main()
        {
            double counter = 0;
            double sum = 0;
            int N = int.Parse(Console.ReadLine());
            int M = N;
            while (M > 0)
            {
                counter++;
                M = M / 10;
            }
            while (N > 0)
            {
                sum += (N % 10) * Math.Pow(10.0, counter-1.0);
                counter--;
                N = N / 10;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}

