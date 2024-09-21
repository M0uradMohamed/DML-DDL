using BikesStoreDB.Data;
using BikesStoreDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Diagnostics;
namespace BikesStoreDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();

          //  Retrieve all categories from the production.categories table.

            var result1 = context.Categories.ToList();

            foreach (var item in result1)
            {
                Console.WriteLine($"category name : {item.CategoryName}");
            }

            Console.WriteLine("------------------------------");

            // Retrieve the first product from the production.products table.

            var result2 = context.Products.First();

            Console.WriteLine($"product name : {result2.ProductName}");

            Console.WriteLine("------------------------------");

           // Retrieve a specific product from the production.products table by ID.

            var result3 = context.Products.Find(7);

            Console.WriteLine($"product id : {result3.ProductId} , product name : {result3.ProductName}");
            Console.WriteLine("------------------------------");

            //Retrieve all products from the production.products table with a certain model year.

            var result4 = context.Products.ToList().Where(p=>p.ModelYear==2016);

            foreach (var item in result4)
            {
                Console.WriteLine($"product id {item.ProductId} , product name :{item.ProductName} , model year {item.ModelYear}");
            }
            Console.WriteLine("------------------------------");

            //Retrieve a specific customer from the sales.customers table by ID.

            var result5 = context.Customers.Find(27);
           
            Console.WriteLine($"customer id : {result5.CustomerId} ,  cutomer name : {result5.FirstName+" "+result5.LastName} ");
            Console.WriteLine("------------------------------");

            //Retrieve a list of product names and their corresponding brand names.

            var result6 = context.Products.Include(p=>p.Brand);

            foreach (var item in result6)
            {
                Console.WriteLine($"product name : {item.ProductName} , brand name : {item.Brand.BrandName }");
            }
            Console.WriteLine("------------------------------");

            //Count the number of products in a specific category.

            var result7 = context.Products.Include(p=>p.Category)
                .Where(p=>p.Category.CategoryName== "Comfort Bicycles").Count();
            
            Console.WriteLine($"count = {result7}");

            Console.WriteLine("------------------------------");

            //Calculate the total list price of all products in a specific category.

            var result8 = context.Products.Sum(p=>p.ListPrice);

            Console.WriteLine($"total = {result8}");

            Console.WriteLine("------------------------------");

            //Calculate the average list price of products.

            var result9 = context.Products.Average(p=>p.ListPrice);

            Console.WriteLine($"Average = {result9}");

            Console.WriteLine("------------------------------");

            //Retrieve orders that are completed.

            var result10 = context.Orders.Where(o=>o.ShippedDate!=null).ToList();

            foreach (var item in result10)
            {
                Console.WriteLine($"order id : {item.OrderId} , order shipping date : {item.ShippedDate} ");
            }
        }
    }
}
