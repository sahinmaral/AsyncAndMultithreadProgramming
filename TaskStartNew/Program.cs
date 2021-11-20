using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskStartNew
{
    class Program
    {
        async static Task Main(string[] args)
        {
            var myTask = Task.Factory.StartNew((obj) =>
            {
                Console.WriteLine("MyTask Start");
                var status = obj as Status;
                status.ThreadId = Thread.CurrentThread.ManagedThreadId;

            }, new Status(){ DateTime = DateTime.Now});

            await myTask;

            Status status = myTask.AsyncState as Status;

            Console.WriteLine(status.ThreadId);
            Console.WriteLine(status.DateTime);

        }
    }

    public class UrlContent
    {
        public string Url { get; set; }
        public int Length { get; set; }
    }

    public class Status
    {
        public int ThreadId { get; set; }
        public DateTime DateTime { get; set; }
    }
}
