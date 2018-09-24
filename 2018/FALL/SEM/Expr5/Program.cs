using System;

namespace Practise
{
    /// <summary>
    /// Counting amount of leap years 
    /// </summary>
    static class Program
    {
        private static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int c = b / 4 - a / 4;
            if (a % 4 == 0 && b % 4 == 0)
                c += 1;

            int amountOfYears = c - (b / 100 - a / 100) + b / 400 - a / 400;

            Console.WriteLine(amountOfYears);
            Console.ReadKey();
        }
        
    }
}