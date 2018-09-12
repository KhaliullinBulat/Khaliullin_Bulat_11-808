using System;
namespace Slide01
{
    class Program
    { 
        /// <summary>
        /// Expr1.
        /// Swap 2 variables without using the third one
        /// </summaryg
        static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}