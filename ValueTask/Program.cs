public class Program
{
    public static int CacheData { get; set; } = 150;

    static async Task Main(string[] args)
    {
        int data = await GetDataAsync();

        int data_valueTask = await GetDataAsync_ValueTask();

        Console.WriteLine(data);
        Console.WriteLine(data_valueTask);
    }

    public static Task<int> GetDataAsync()
    {
        return Task.FromResult(CacheData);
    }

    public static ValueTask<int> GetDataAsync_ValueTask()
    {
        return new ValueTask<int>(CacheData);
    }
}