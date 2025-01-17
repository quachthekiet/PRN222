namespace Slot2_UsingPLINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = Enumerable.Range(0, 1000_000);

            var resultList = range.Where(i => i % 3 == 0).ToList();
            Console.WriteLine($"Sequential: Total times are {resultList.Count} ");

            resultList = range.AsParallel().Where(i => i % 3 == 0).ToList();
            Console.WriteLine($"Parallel: Total time are {resultList.Count}");
            resultList = (from i in range.AsParallel()
                          where i % 3 == 0
                          select i).ToList();
            Console.WriteLine($"Parallel: Total times are {resultList.Count}");
            Console.ReadLine();
        }
    }
}
