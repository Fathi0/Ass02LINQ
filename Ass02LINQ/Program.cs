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
        }
    }
}
