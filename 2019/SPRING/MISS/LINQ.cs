using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContrLINQ
{
    // ВТОРОЕ ЗАДАНИЕ
    public static class IEnumerableExtension<TItem>
    {
        public static IEnumerable<Tuple<TItem, TItem>> SecondExercise (IEnumerable<TItem> first,
            IEnumerable<TItem> second, Func<TItem, TItem, bool> condition)
        {
            var firstInArr = first.ToArray();
            int index = 0;
            foreach (var el in second)
            {
                index++;
                if (condition(el, firstInArr[index]))
                    yield return new Tuple<TItem, TItem>(el, firstInArr[index]);
            }
        }
    }

    class Program
    {
        // ПЕРВОЕ ЗАДАНИЕ
        static void FirstExercise(int[] input)
        {
            int counter = 0;
            int secCounter = 0;
            input
                .Where(w =>
                {
                    counter++;
                    return counter % 3 != 0;
                })
                .Select(w =>
                {
                    secCounter++;
                    if (secCounter % 2 == 1)
                        return 2 * w;
                    else
                        return w;
                }); 
        }

        static void ThirdExercise(IEnumerable<string[3]> A, IEnumerable<string[3]> B, IEnumerable<string[3]> C, IEnumerable<string[3]> D)
        {
            ///...
        }
    }


}
