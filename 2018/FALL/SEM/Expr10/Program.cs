using System;

namespace CS
{
    /// <summary>
    /// Expr10
    /// Khaliullin Bulat
    /// Finding sum of number less than 1000 and divisible by 3 or by 5
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int thousand = 1000;
            int three = 3;
            int five = 5;

            int fifteen = three * five;
            int amountThree = thousand / three;
            int amountFive = thousand / five;
            int amountFifteen = thousand / fifteen;

            int sumFive = (five + 1000) * amountFive / 2;
            int sumThree = (three + 999) * amountThree / 2;
            int sumFifteen = (fifteen + 990) * amountFifteen / 2;

            Console.WriteLine(sumFive + sumThree - sumFifteen);
            Console.ReadKey();
        }
    }
}
