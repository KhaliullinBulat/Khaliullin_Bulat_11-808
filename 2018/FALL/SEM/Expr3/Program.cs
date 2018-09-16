using System;
namespace Slide01
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main()
        {
            int hours = Convert.ToInt32(Console.ReadLine());
            int n = hours % 6;
            int degree;
            if (hours % 12 >= 6)
                degree = (6 - n) * 30;
            else
                degree = n * 30;
            Console.WriteLine(degree);
            Console.ReadKey();
        }
    }
}