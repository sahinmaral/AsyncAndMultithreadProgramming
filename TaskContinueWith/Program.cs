using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TaskContinueWith
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //await ContinueWithExample();
            //await ContinueWithExample2();
            await ContinueWithExample3();
        }

        public static void Run(Task<string> task)
        {
            Console.WriteLine("Data Result Length : " + task.Result.Length);
        }
        
        static async Task ContinueWithExample2()
        {

            Console.WriteLine("Hello World");

            var myTask = new HttpClient().GetStringAsync("https://www.google.com");

            Console.WriteLine("Arada yapılacak işler");

            var data = await myTask;
            
            Console.WriteLine("Data Result Length : " + myTask.Result.Length);
            
        }
        
        static async Task ContinueWithExample3()
        {

            Console.WriteLine("Hello World");

            var myTask = new HttpClient().GetStringAsync("https://www.google.com").ContinueWith(Run);

            Console.WriteLine("Arada yapılacak işler");

            await myTask;
        }

        private static async Task ContinueWithExample()
        {
            Console.WriteLine("Hello World");

            var myTask = new HttpClient().GetStringAsync("https://www.google.com").ContinueWith((data) =>
            {
                Console.WriteLine("Data Result Length : " + data.Result.Length);
            });

            Console.WriteLine("Arada yapılacak işler");

            await myTask;
        }
    }
}
