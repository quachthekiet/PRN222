using System.Collections.Concurrent;
using System.Diagnostics;

namespace Slot2_UsingPLINQ02
{
    internal class Program
    {
        private static bool IsPrime(int n)
        {
            if(n < 2)
                return false;
            if(n == 2)
                return true;
            if(n % 2 == 0)
                return false;
            for(int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if(n % i == 0)
                    return false;
            }
            return true;
        }

        private static IList<int> GetPrimeListWithParallel(IList<int> list)
        {
            var primeList = new ConcurrentBag<int>();
            Parallel.ForEach(list, num =>
                        {
                            if(IsPrime(num))
                                primeList.Add(num);
                        });
            return primeList.ToList();
        }
        static void Main(string[] args)
        {
            var limit = 2_000_000;
            var numbers = Enumerable.Range(0, limit).ToList();

            var watch = Stopwatch.StartNew();
            var primeList = GetPrimeListWithParallel(numbers);
            watch.Stop();

            var watchForParallel = Stopwatch.StartNew();
            var primeListForParallel = GetPrimeListWithParallel(numbers);
            watchForParallel.Stop();

            Console.WriteLine($"Sequential: Total prime numbers: {primeList.Count}, Time taken: {watch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Parallel: Total prime numbets {primeListForParallel.Count}, Time taken: {watchForParallel.ElapsedMilliseconds} ms");
            Console.WriteLine("Press any key to exit. ");
            Console.ReadLine();
        }
    }
}
