using System;
namespace Slide01
{
    /// <summary>
    /// Replacing first and third numerals of three-digit number
    /// </summary>
    class Program
    {
        static void Main()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int firstNumeral = number / 100;
            int secondNumeral = (number% 100) / 10;
            int thirdNumeral = number % 10;
            Console.WriteLine(thirdNumeral*100 + secondNumeral*10 + firstNumeral);
            Console.ReadKey();
        }
    }
}