using System;
using static Day1_LINQ.ListGenerators;

namespace Day1_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators 
            //var result = ProductList
            //    .Where(o => o.UnitsInStock == 0);
            //foreach (var product in result)
            //    Console.WriteLine(product);
            //Console.WriteLine("======================================================");
            //var result = ProductList
            //         .Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);

            //foreach (var product in result)
            //    Console.WriteLine(product);
            //Console.WriteLine("======================================================");
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Select((word, index) => new { Word = word, Index = index }).Where(x => x.Word.Length < x.Index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Index} -> {item.Word}");
            //} 
            #endregion

            #region LINQ - Element Operators 
            //var firstResult = ProductList.First(x => x.UnitsInStock == 0);
            //Console.WriteLine(firstResult);

            //Console.WriteLine("============================================================");

            //var firstExpensive = ProductList
            //    .FirstOrDefault(p => p.UnitPrice > 1000);

            //Console.WriteLine(firstExpensive != null ? firstExpensive : "No product with price > 1000");
            //Console.WriteLine("============================================================");
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var secountnumber = Arr.Where(x => x > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(secountnumber);
            //Console.WriteLine("============================================================");

            #endregion

            #region LINQ - Aggregate Operators
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(x => x % 2 == 1);
            //Console.WriteLine(result);
            //Console.WriteLine("===========================================================");
            //var result1 = CustomerList
            //                .Select(c => new
            //                {
            //                    CustomerName = c.Name,
            //                    OrdersCount = c.Orders.Count()
            //                });

            //foreach (var item in result1)
            //    Console.WriteLine($"{item.CustomerName} ===>> {item.OrdersCount} ");

            //Console.WriteLine("===========================================================");
            //var result = ProductList.GroupBy(c => c.Category,
            //(key, group) => new { CategoriesName = key, Count = group.Count() });

            //foreach (var item in result)
            //    Console.WriteLine($"{item.CategoriesName} ==>> {item.Count}");


            //Console.WriteLine("===========================================================");
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();
            //Console.WriteLine(result);
            //Console.WriteLine("===========================================================");
            //var result = ProductList.GroupBy(c => c.Category, (key, total)
            //    => new { key, TotalUnits = total.Sum(p => p.UnitsInStock) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.key}: {item.TotalUnits}");
            //}
            //Console.WriteLine("===========================================================");
            //var result = ProductList.GroupBy(c => c.Category, (key, total)
            //    => new { key, cheapest_price = total.Min(p => p.UnitPrice) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.key}: {item.cheapest_price}");
            //}
            //Console.WriteLine("===========================================================");
            //var result = from p in ProductList
            //             group p by p.Category into g
            //             let cheapestPrice = g.Min(p => p.UnitPrice)
            //             from prod in g
            //             where prod.UnitPrice == cheapestPrice
            //             select new
            //             {
            //                 Category = g.Key,
            //                 Product = prod.ProductName,
            //                 Price = prod.UnitPrice
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category}: {item.Product} - {item.Price}");
            //}
            //Console.WriteLine("===========================================================");
            // var result = ProductList.GroupBy(c => c.Category, (key, total)
            //=> new { key, expensive_price = total.Max(p => p.UnitPrice) });
            // foreach (var item in result)
            //     Console.WriteLine($"{item.key}: {item.expensive_price}");
            //Console.WriteLine("===========================================================");

            // var result2 = ProductList.GroupBy(c => c.Category, (key, total)
            //=> new { key, expensive_price = total.Where(p => p.UnitPrice == total.Max(x => x.UnitPrice)) });
            // foreach (var item in result2)
            // {
            //     Console.WriteLine($"{item.key}");
            //     foreach (var product in item.expensive_price)
            //     {
            //         Console.WriteLine($"   {product.ProductName} - {product.UnitPrice}");
            //     }
            // }
            //Console.WriteLine("===========================================================");
            //var result = ProductList.GroupBy(c => c.Category, (key, product) => new
            //{
            //    key,
            //    Average = product.Average(a => a.UnitPrice),
            //});
            //foreach (var item in result)
            //    Console.WriteLine($"{item.key}: {item.Average:F2}");
            #endregion

            #region LINQ - Ordering Operators

            //var result = ProductList.OrderBy(n => n.ProductName);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            //Console.WriteLine("===============================================");
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr
            //    .OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in result)
            //    Console.WriteLine(word);
            //Console.WriteLine("===============================================");
            //var result = ProductList.OrderByDescending(n => n.UnitsInStock);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            //Console.WriteLine("===============================================");
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.OrderByDescending(n => n.Length).ThenBy(a => a);
            //foreach (var item in result)
            //Console.WriteLine(item);
            //Console.WriteLine("===============================================");
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = words
            //    .OrderBy(w => w.Length)                 
            //    .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in result)
            //    Console.WriteLine(word);

            //Console.WriteLine("===============================================");
            //var result = ProductList
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);

            //foreach (var product in result)
            //    Console.WriteLine(product);

            //Console.WriteLine("===============================================");
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr
            //    .OrderBy(w => w.Length)
            //    .ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in result)
            //    Console.WriteLine(word);

            //Console.WriteLine("===============================================");
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr
            //    .Where(word => word.Length > 1 && word[1] == 'i')
            //    .Reverse()
            //    .ToList();

            //result.ForEach(Console.WriteLine);
            //Console.WriteLine("===============================================");
            #endregion

            #region LINQ – Transformation Operators
            //var result = ProductList.Select(p => p.ProductName).ToList();
            //result.ForEach(Console.WriteLine);
            //Console.WriteLine("===============================================");
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result = words.Select(word => new
            //{
            //    Upper = word.ToUpper(),
            //    Lower = word.ToLower()
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Upper: {item.Upper}, Lower: {item.Lower}");
            //}
            //Console.WriteLine("===============================================");
            //var result = ProductList.Select(p => new
            //{
            //    p.ProductID,
            //    p.ProductName,
            //    p.Category,
            //    Price = p.UnitPrice,
            //    p.UnitsInStock
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("===============================================");
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((n, i) => new { Word = n, Index = i, Match = n == i });
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Word} : {item.Match}");
            //}
            //Console.WriteLine("===============================================");
            // int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            // int[] numbersB = { 1, 3, 5, 7, 8 };
            // var result = numbersA
            //.SelectMany(a => numbersB, (a, b) => new { A = a, B = b }).Where(pair => pair.A < pair.B);
            // Console.WriteLine("Pairs where a < b:");
            // foreach (var pair in result)
            // {
            //     Console.WriteLine($"{pair.A} is less than {pair.B}");
            // }
            //Console.WriteLine("===============================================");
            //var result = CustomerList.SelectMany(c => c.Orders).Where(c => c.Total < 500);
            //foreach (var order in result)
            //    Console.WriteLine($"Order ID: {order.Id}, Date: {order.OrderDate.ToShortDateString()}, Total: {order.Total:C}");            //Console.WriteLine("===============================================");
            //Console.WriteLine("===============================================");
            //var recentOrders = new List<Order>();

            //foreach (var customer in ListGenerators.CustomerList)
            //{
            //    foreach (var order in customer.Orders)
            //    {
            //        if (order.OrderDate.Year >= 1998)
            //        {
            //            recentOrders.Add(order);
            //        }
            //    }
            //}

            //Console.WriteLine("Orders from 1998 or later:");
            //foreach (var order in recentOrders)
            //{
            //    Console.WriteLine($"Order ID: {order.Id}, Date: {order.OrderDate.ToShortDateString()}, Total: {order.Total:C}");
            //}
            //Console.WriteLine("===============================================");

            #endregion

            #region Partitioning Operators
            //var result = CustomerList
            //.Where(c => c.Address == "Obere Str. 57")
            //.SelectMany(c => c.Orders)
            //.Take(3);
            //foreach (var order in result)
            //{
            //    Console.WriteLine($"Order ID: {order.Id}, Date: {order.OrderDate.ToShortDateString()}, Total: {order.Total:C}");
            //}
            //Console.WriteLine("========================================================");
            //var skip2Orders = ListGenerators.CustomerList
            //.Where(c => c.City == "Washington")
            //.SelectMany(c => c.Orders)
            //.Skip(2);
            //foreach (var order in result)
            //{
            //    Console.WriteLine($"Order ID: {order.Id}, Date: {order.OrderDate.ToShortDateString()}, Total: {order.Total:C}");
            //}
            //Console.WriteLine("========================================================");
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Console.WriteLine("========================================================");
            //var result = numbers.TakeWhile((n, i) => n >= i);
            //foreach (var i in result)
            //    Console.WriteLine(i);
            //Console.WriteLine("========================================================");
            //var result = numbers.Where(n => n % 3 == 0);
            //foreach (var num in result)
            //    Console.WriteLine(num);
            //Console.WriteLine("========================================================");
            //var result = numbers.SkipWhile((n, i) => n >= i);

            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine("========================================================");
            //var groupedProducts = ProductList
            //        .Where(p => p.UnitsInStock != 0) // التأكد أن المنتج غير متوفر
            //        .GroupBy(p => p.Category)
            //        .ToList();

            //foreach (var group in groupedProducts)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"\t{product.ProductName} - UnitsInStock: {product.UnitsInStock}");
            //    }
            //}

            //Console.WriteLine("========================================================");
            //var groupedProducts1 = ProductList
            //        .GroupBy(p => p.Category)
            //        .Where(g => g.All(p => p.UnitsInStock > 0))
            //        .ToList();

            //// لعرض النتائج:
            //foreach (var group in groupedProducts1)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"\t{product.ProductName} - UnitsInStock: {product.UnitsInStock}");
            //    }
            //}

            #endregion

        }
    }
}
