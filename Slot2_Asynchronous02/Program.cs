namespace Slot2_Asynchronous02
{
    internal class Program
    {
        private static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for(int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Method 1");
                    count += 1;
                }
            });
            return count;
        }

        private static void Method2()
        {
            for(int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 2");
            }
        }

        private static void Method3(int count)
        {
            Console.WriteLine("Method 3 is called");
            Console.WriteLine($"Total count is {count}");
        }

        private static async void callMethod()
        {
            Method2();
            int count = await Method1();
            Method3(count);
        }
        static void Main(string[] args)
        {
            callMethod();
        }
    }
}
