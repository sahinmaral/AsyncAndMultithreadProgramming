using System;
using System.IO;
using System.Threading.Tasks;

namespace TaskFromResult
{
    class Program
    {
        public static string CacheData { get; set; }

        static async Task Main(string[] args)
        {
            CacheData = await GetDataAsync();

            Console.WriteLine(CacheData);
        }

        public static Task<string> GetDataAsync()
        {
            if (String.IsNullOrEmpty(CacheData))
            {
                return File.ReadAllTextAsync("file.txt");
            }

            return Task.FromResult<string>(CacheData);
        }
    }
}
