using Day02_EntityFramework.Context;
using Day02_EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace Day02_EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new E_commerceContext();
            #region ADDED
            //var customers = new List<Customer>
            //{
            //    new Customer { Name = "Sara Ali", Email = "sara@example.com" },
            //    new Customer { Name = "Mahmoud Akl", Email = "mahmoud@example.com" },
            //    new Customer { Name = "Omar Hassan", Email = "omar@example.com" }
            //};

            //var categories = new List<Category>
            //{
            //    new Category { Name = "Books" },
            //    new Category { Name = "Electronics" },
            //    new Category { Name = "Clothes" }
            //};

            //// 📦 إضافة منتجات
            //var products = new List<Product>
            //{
            //    new Product { Name = "C# Programming", Price = 300, Category = categories[0] },
            //    new Product { Name = "Laptop", Price = 15000, Category = categories[1] },
            //    new Product { Name = "T-Shirt", Price = 200, Category = categories[2] },
            //    new Product { Name = "Headphones", Price = 500, Category = categories[1] }
            //};

            //var order1 = new Order { OrderDate = DateTime.Now, Customer = customers[0] };
            //var order2 = new Order { OrderDate = DateTime.Now.AddDays(-1), Customer = customers[1] };

            //var orderDetails = new List<OrderDetail>
            //    {
            //        new OrderDetail { Order = order1, Product = products[0], Quantity = 2 }, // Sara اشترت كتابين
            //        new OrderDetail { Order = order1, Product = products[1], Quantity = 1 }, // Sara اشترت لابتوب
            //        new OrderDetail { Order = order2, Product = products[2], Quantity = 3 }, // Mahmoud اشترى 3 تيشيرت
            //        new OrderDetail { Order = order2, Product = products[3], Quantity = 1 }  // Mahmoud اشترى سماعة
            //    };

            //context.AddRange(customers);
            //context.AddRange(categories);
            //context.AddRange(products);
            //context.AddRange(order1);
            //context.AddRange(order2);
            //context.AddRange(orderDetails);

            //context.SaveChanges(); 
            #endregion

            #region Join
            //var productcustomer = (from C in context.customers
            //                       join O in context.orders
            //                       on C.CustomerId equals O.CustomerId
            //                       join OD in context.orderDetails
            //                       on O.OrderId equals OD.OrderId
            //                       join P in context.Products
            //                       on OD.ProductId equals P.ProductId
            //                       select new
            //                       {
            //                           orderId = O.CustomerId,
            //                           CustomerName = C.Name,
            //                           OrderDate = O.OrderDate,
            //                           ProductName = P.Name
            //                       }).ToList();
            //foreach (var product in productcustomer)
            //    Console.WriteLine($"orderId:{product.orderId}, CustomerName: {product.CustomerName}, OrderDate: {product.OrderDate}, ProductName: {product.ProductName} ");


            #endregion


        }
    }
}
