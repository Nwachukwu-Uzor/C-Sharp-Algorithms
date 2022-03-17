using System;

namespace C_Sharp.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = MostFrequentDay.GetFirstDay(2022);
            Console.WriteLine($"FirstDay: {result.FirstDay}\nLastDay: {result.LastDay}");
            Console.ReadLine();
        }
    }
}
