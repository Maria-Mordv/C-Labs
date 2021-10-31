using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public static class Dates
    {
        public static void RecursionDate()
        {
            DateTime FirstDateStart;
            DateTime FirstDateFinish;
            DateTime SecondDateStart;
            DateTime SecondDateFinish;

            do
            {
                FirstDateStart = IOUtils.SafeReadDate(null);
                FirstDateFinish = IOUtils.SafeReadDate(null);
                if (FirstDateStart > FirstDateFinish)
                {
                    Console.WriteLine("\nFirst date should be earlier than second date!\n");
                }
            } while (FirstDateStart > FirstDateFinish);

            do
            {
                SecondDateStart = IOUtils.SafeReadDate(null);
                SecondDateFinish = IOUtils.SafeReadDate(null);
                if (SecondDateStart > SecondDateFinish)
                {
                    Console.WriteLine("\nFirst date should be earlier than second date!\n");
                }
            } while (SecondDateStart > SecondDateFinish);

            int N = (NFinder(FirstDateStart, FirstDateFinish, SecondDateStart, SecondDateFinish)).Days;
            if (N == 0)
            {
                Console.WriteLine("\nDates don't overlay");
            }
            else
            {
                //N += 1;
                if (IsPrimeNumber(N) == "true")
                {
                    Console.WriteLine("\nN = {0}", N);
                    Console.WriteLine("\nN is prime number");
                }
                if (IsPrimeNumber(N) == "false")
                {
                    Console.WriteLine("\nN = {0}", N);
                    Console.WriteLine("\nN is not prime number");
                }
                if (IsPrimeNumber(N) == null)
                {
                    Console.WriteLine("\nTime is out");
                }
            }
        }

        public static TimeSpan NFinder(DateTime FirstDateStart, DateTime FirstDateFinish, DateTime SecondDateStart, DateTime SecondDateFinish)
        {
            TimeSpan N = TimeSpan.Zero;
            if ((SecondDateFinish >= FirstDateStart) && (FirstDateFinish >= SecondDateStart))
            {
                if (SecondDateStart >= FirstDateStart)
                {
                    if (FirstDateFinish >= SecondDateFinish)
                    {
                        return (SecondDateFinish - SecondDateStart) + TimeSpan.FromDays(1);
                    }
                    return (FirstDateFinish - SecondDateStart) + TimeSpan.FromDays(1);
                }
                if (SecondDateFinish >= FirstDateFinish)
                {
                    return (FirstDateFinish - FirstDateStart) + TimeSpan.FromDays(1);
                }
                return (SecondDateFinish - FirstDateStart) + TimeSpan.FromDays(1);
            }
            return N;
        }

        public static string IsPrimeNumber(int N)
        {
            DateTime startTime = DateTime.Now;
            for (int I = 2; I < N; I++)
            {
                if (DateTime.Now.Subtract(startTime) >= TimeSpan.FromSeconds(3))
                {
                    return null;
                }
                if (N % I == 0)
                {
                    return "false";
                }
            }
            return "true";
        }
    }
}
