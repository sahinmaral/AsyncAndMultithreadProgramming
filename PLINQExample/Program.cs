using PLINQExample.Models;

AdventureWorks2022Context context = new AdventureWorks2022Context();

var products = (from p in context.Products.AsParallel()
               where p.ListPrice > 10M
               select p).Take(10);

products.ForAll((product) =>
{
    Console.WriteLine(product.Name);
});


