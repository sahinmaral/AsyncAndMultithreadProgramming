bool ExampleProcess(int number)
{
    return number % 2 == 0;
}

void FilteringWithoutParallel(List<int> array)
{
    array.Where(ExampleProcess).ToList().ForEach((number) =>
    {
        Console.WriteLine($"Number : {number}");
    });
}

void FilteringWithParallel(List<int> array)
{
    array.AsParallel().Where(ExampleProcess).ToList().ForEach((number) =>
    {
        Console.WriteLine($"Number : {number}");
    });


}

void FilteringWithParallel_V2(List<int> array)
{
    var newArray = array.AsParallel().Where(ExampleProcess);
    newArray.ForAll((number) =>
    {
        Console.WriteLine($"Number : {number}");
    });
}


var array = Enumerable.Range(0, 100).ToList();

FilteringWithParallel_V2(array);



