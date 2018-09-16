using System;

namespace CS
{
    /// <summary>
    /// Finding amount of numbers less than entered nubmer which also has entered simple dividers
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int firstDivider = Convert.ToInt32(Console.ReadLine());
            int secondDivider = Convert.ToInt32(Console.ReadLine());
            int amount = (number - 1) / firstDivider + (number - 1) / secondDivider;

            if (firstDivider % secondDivider == 0 || secondDivider % firstDivider == 0)
                if (firstDivider % secondDivider == 0)
                    amount = amount - (number - 1) / firstDivider;
                else
                    amount = amount - (number - 1) / secondDivider;

            Console.WriteLine(amount);
            Console.ReadKey();
        }
    }
}
