using System;

namespace Practise
{
    /// <summary>
    /// Khaliullin Bulat
    /// Cond3
    /// Is the next or the last ticket happy
    /// </summary>
    static class Program
    {
        private static bool Main()
        {
            int numberOfTicket = Convert.ToInt32(Console.ReadLine());
            int nextOf = numberOfTicket + 1;
            int firstThree1 = nextOf / 100000 + (nextOf % 100000) / 10000 + (nextOf % 10000) / 1000;
            int lastThree1 = (nextOf % 1000) / 100 + (nextOf % 100) / 10 + nextOf % 10;
            int previousOf = numberOfTicket - 1;
            int firstThree2 = previousOf / 100000 + (previousOf % 100000) / 10000 + (previousOf % 10000) / 1000;
            int lastThree2 = (previousOf % 1000) / 100 + (previousOf % 100) / 10 + previousOf % 10;
            if (firstThree1 == lastThree1 && firstThree2 == lastThree2)
                return true;
            else
                return false;
        }
        
    }
}