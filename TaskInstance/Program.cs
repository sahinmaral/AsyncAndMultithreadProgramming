public class Program
{
    public static void Main(string[] args)
    {
        TaskInstanceFeatureOne();
    }

    public static void TaskInstanceFeatureOne()
    {
        var data = GetData();
        Console.WriteLine(data);
    }

    public static string GetData()
    {
        var task = new HttpClient().GetStringAsync("https://www.google.com");

        return task.Result;
    }
}