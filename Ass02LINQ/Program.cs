using LINQ.DataSources;
using LINQ.Models;
using static LINQ.DataSources.Source;
namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            //var result = ProductList.OrderByDescending(P => P.UnitPrice).Take(3);
            //foreach(var P in result)
            //{
            //    Console.WriteLine($"{P.ProductName} - {P.UnitPrice}");
            //}
            //Q2
            //var result = ProductList.Skip(5).Take(5);
            //foreach(var P in result)
            //{
            //    Console.WriteLine($"{P.ProductName} - {P.UnitPrice}");
            //}
            //Q3
            //var result = ProductList.OrderBy(P => P.UnitPrice).TakeWhile(P => P.UnitPrice < 25);
            //foreach(var P in result)
            //{
            //    Console.WriteLine($"{P.ProductName} - {P.UnitPrice}");
            //}
            //Q4
            //bool result = ProductList.Where(P => P.Category == "Seafood").All(P => P.UnitPrice > 0);
            //Console.WriteLine(result);
            //Q5
            //int[] ids = { 3, 9, 13, 18 };
            //Console.WriteLine(ids.Contains(9));
            //Q6
            //var result = ProductList.GroupBy(P => P.Category);
            //foreach(var group in result)
            //{
            //    Console.WriteLine($"{group.Key}: {group.Count()}");
            //}
        }
    }
}
