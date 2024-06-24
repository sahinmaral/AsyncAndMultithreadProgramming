long totalByte = 0;

string picturesPath = $"{Path.Combine(Directory.GetCurrentDirectory(), "images")}";

var files = Directory.GetFiles(picturesPath);

var thumbnailDirectory = $"{Path.Combine(Directory.GetCurrentDirectory(), "images/thumbnail_parallelFor")}";
var isThumbnailDirectoryExists = Directory.Exists(thumbnailDirectory);
if (!isThumbnailDirectoryExists)
    Directory.CreateDirectory(thumbnailDirectory);


Parallel.For(0, files.Length, (index) =>
{
    var file = new FileInfo(files[index]);
    Interlocked.Add(ref totalByte, file.Length);
});

Console.WriteLine($"Total byte : {totalByte}");

ParallelForLocalProperty();


void ParallelForLocalProperty()
{
    int total = 0;
    var numbers = Enumerable.Range(0, 100).ToList();
    Parallel.ForEach(numbers, () => 0, (x, loop, subtotal) =>
    {
        subtotal += x;
        return subtotal;
    }, (y) => Interlocked.Add(ref total, y));

    Console.WriteLine($"Total : {total}");
}

