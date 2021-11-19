using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace TaskWaitAll
{
    public class UrlContent
    {
        public string Url { get; set; }
        public int Length { get; set; }
    }

    class Program
    {

        static async Task Main(string[] args)
        {

            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId}");

            List<string> urlLists = new List<string>
            {
                "https://www.amazon.com",
                "https://www.n11.com",
                "https://www.google.com",
                "https://www.microsoft.com",
                "https://www.facebook.com"
            };

            List<Task<UrlContent>> taskList = new List<Task<UrlContent>>();

            urlLists.ForEach(x => { taskList.Add(GetContentAsync(x)); });

            Console.WriteLine("WaitAll Start");

            bool taskDoneInTime = Task.WaitAll(taskList.ToArray(),1);

            Console.WriteLine("Task Done In Time : " + taskDoneInTime);

            Console.WriteLine("WaitAll End");

            /*Console.WriteLine($"{firstData.Result.Url} - {firstData.Result.Length}");*/

        }

        private static async Task<UrlContent> GetContentAsync(string url)
        {
            UrlContent content = new UrlContent
            {
                Length = new HttpClient().GetStringAsync(url).Result.Length,
                Url = url
            };

            Console.WriteLine($"GetContentAsync Thread No : {Thread.CurrentThread.ManagedThreadId}");

            return content;
        }
    }
}