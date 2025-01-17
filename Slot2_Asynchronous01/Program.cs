using System.Net;

namespace Slot2_Asynchronous01
{
    internal class Program
    {
        private static void DownloadAsychronously()
        {
            WebClient webClient = new WebClient();
            webClient.DownloadStringCompleted +=
                new DownloadStringCompletedEventHandler(DownLoadComplete);
            webClient.DownloadStringAsync(new Uri("http://aspnet.com"));
        }

        private static void DownLoadComplete(object sender, DownloadStringCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                Console.WriteLine("Some erro has occured.");
            }
            Console.WriteLine(e.Result);
            Console.WriteLine(new string('*', 30));
            Console.WriteLine("Download completed");

        }
        static void Main(string[] args)
        {
            DownloadAsychronously();
            Console.WriteLine("Main thread: Done");
            Console.WriteLine(new string('*', 30));
            Console.ReadLine();
        }
    }
}
