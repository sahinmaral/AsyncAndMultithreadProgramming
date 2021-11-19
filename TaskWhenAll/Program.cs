using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace TaskWhenAll
{
    public class UrlContent
    {
        public string Url { get; set; }
        public int Length { get; set; }
    }


    internal static class Program
    {
        private static async Task Main()
        {
            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId}");
            
            List<string> urlLists = new List<string>
            {
                "https://www.google.com",
                "https://www.microsoft.com",
                "https://www.amazon.com",
                "https://www.n11.com",
                "https://www.facebook.com"
            };

            List<Task<UrlContent>> taskList = new List<Task<UrlContent>>();
            
            urlLists.ForEach(x =>
            {
                taskList.Add(GetContentAsync(x));
            });

            var contents = Task.WhenAll(taskList);

            Console.WriteLine("WhenAll metodu sonrası başka işler");

            var data = await contents;

            /*contents.ToList().ForEach(x =>
            {
                Console.WriteLine($"{x.Url} Length {x.Length}");
            });*/
        }

        private static async Task<UrlContent> GetContentAsync(string url){
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