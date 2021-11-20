using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace TaskWaitAny
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

            int firstTaskIndex = Task.WaitAny(taskList.ToArray());

            Console.WriteLine("Task Done Index : " + firstTaskIndex);

            Console.WriteLine("WaitAll End");


            Console.WriteLine($"{taskList[firstTaskIndex].Result.Url} - {taskList[firstTaskIndex].Result.Length}");

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
