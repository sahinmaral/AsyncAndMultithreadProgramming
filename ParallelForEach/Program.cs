using System.Diagnostics;
using System.Drawing;

public class Program
{
    static void Main(string[] args)
    {
        string picturesPath = $"{Path.Combine(Directory.GetCurrentDirectory(),"images")}";

        var files = Directory.GetFiles(picturesPath);

        //NormalFor(files,picturesPath);
        //ParallelFor(files, picturesPath);

        //ParallelFor_V2(files, picturesPath);

        ParallelFor_V3();

        Console.WriteLine("islem bitti");
    }

    /// <summary>
    /// Resimleri isledigimiz thread hep ayni kalacaktir. Bu yuzden de senkron olarak calisacaktir ve parallel foreach e gore daha yavas islenecektir.
    /// </summary>
    /// <param name="files"></param>
    /// <param name="picturesPath"></param>
    public static void NormalFor(string[] files, string picturesPath)
    {
        var thumbnailDirectory = $"{Path.Combine(Directory.GetCurrentDirectory(), "images/thumbnail_normalFor")}";
        var isThumbnailDirectoryExists = Directory.Exists(thumbnailDirectory);
        if (!isThumbnailDirectoryExists)
            Directory.CreateDirectory(thumbnailDirectory);

        Stopwatch stopwatch= new Stopwatch();
        stopwatch.Start();

        foreach (var file in files)
        {
            Console.WriteLine($"Thread no : {Thread.CurrentThread.ManagedThreadId}");

            Image img = new Bitmap(file);
            var thumbnail = img.GetThumbnailImage(50, 50, () => false, IntPtr.Zero);

            thumbnail.Save(Path.Combine(picturesPath, "thumbnail_normalFor", Path.GetFileName(file)));
        }

        stopwatch.Stop();
        Console.WriteLine($"Stopwatch elapsed miliseconds for normalfor: {stopwatch.ElapsedMilliseconds}");
    }

    /// <summary>
    /// Resimleri islerken her resmi ayri ayri thread ler uzerinde isleyecektir. Veri sayisi arttiginda performans artisi gozlemlenir.
    /// </summary>
    /// <param name="files"></param>
    /// <param name="picturesPath"></param>
    public static void ParallelFor(string[] files,string picturesPath)
    {
        var thumbnailDirectory = $"{Path.Combine(Directory.GetCurrentDirectory(), "images/thumbnail_parallelFor")}";
        var isThumbnailDirectoryExists = Directory.Exists(thumbnailDirectory);
        if (!isThumbnailDirectoryExists)
            Directory.CreateDirectory(thumbnailDirectory);

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        Parallel.ForEach(files, file =>
        {
            Console.WriteLine($"Thread no : {Thread.CurrentThread.ManagedThreadId}");

            Image img = new Bitmap(file);
            var thumbnail = img.GetThumbnailImage(50, 50, () => false, IntPtr.Zero);

            thumbnail.Save(Path.Combine(picturesPath, "thumbnail_parallelFor", Path.GetFileName(file)));

        });

        stopwatch.Stop();
        Console.WriteLine($"Stopwatch elapsed miliseconds for parallelfor: {stopwatch.ElapsedMilliseconds}");
    }

    public static void ParallelFor_V2(string[] files,string picturesPath)
    {
        long filesInByte = 0;

        Parallel.ForEach(files, file =>
        {
            Console.WriteLine($"Thread no : {Thread.CurrentThread.ManagedThreadId}");

            FileInfo f = new FileInfo(file);

            Interlocked.Add(ref filesInByte,f.Length);

        });

        Console.WriteLine($"Toplam boyut : {filesInByte}");

    }

    public static void ParallelFor_V3()
    {
        int value = 0;

        Parallel.ForEach(Enumerable.Range(1, 1000).ToList(), (number) =>
        {
            value = number;
        });

        Console.WriteLine(value);
    }
}