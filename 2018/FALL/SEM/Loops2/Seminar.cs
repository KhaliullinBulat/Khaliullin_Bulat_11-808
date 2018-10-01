using System;

namespace Practise
{
    /// <summary>
    /// Khaliullin Bulat
    /// Loops2
    /// Finding the number of three-digit natural numbers whose sum of digits is N
    /// </summary>
    static class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double counter = 0;
            if (N <= 14)
                counter = N * (N - 1) * 0.5;
            else
                counter = (29 - N) * (28 - N) * 0.5;

            Console.WriteLine(counter);
            Console.ReadKey();
        }
    }
}

