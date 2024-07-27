global using static LINQ_Lab.ListGenerators;
using System.Threading.Channels;


namespace LINQ_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction 
            //Task 1 - Find all products that are out of stock.
            var res = ProductList.Where(p => p.UnitsInStock == 0);
            //foreach (var item in res) { Console.WriteLine(item); }

            //Task 2 - Find all products that are in stock and cost more than 3.00 per unit.
            res = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);
            //foreach(var item in res) { Console.WriteLine(item); }

            //Task 3 - Returns digits whose name is shorter than their value.
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var DigitList = Arr.Where((digit, index) => digit.Length < index);
            //foreach (var item in DigitList) { Console.WriteLine(item); }
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    if (Arr[i].Length < i)
            //        Console.WriteLine(Arr[i]);
            //} 
            #endregion

            #region LINQ - Element Operators
            //Task 1 - Get first Product out of Stock 
            var res1 = ProductList.First(p => p.UnitsInStock == 0);
            //Console.WriteLine(res1);

            //Task 2 - Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            var res2 = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);

            //Task 3 - Retrieve the second number greater than 5 
            int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var res3 = Arr2.Where(digit => digit > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(res3);

            #endregion

            #region LINQ - Set Operators
            //Task 1 -  Find the unique Category names from Product List
            var res4 = ProductList.DistinctBy(p => p.Category);
            //foreach (var item in res4) { Console.WriteLine(item); }

            //Task 2 - Produce a Sequence containing the unique first letter from both product and customer names.
            var Prod = ProductList.Select(p => p.ProductName[0]);
            var Cust = CustomerList.Select(p => p.CompanyName[0]);
            var res5 = Prod.Union(Cust).Distinct();

            //Task 3 - Create one sequence that contains the common first letter from both product and customer names.
            var res6 = Prod.Intersect(Cust);
            //foreach (var item in res6) { Console.WriteLine(item); }

            //Task 4 - Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            var res7 = Prod.Except(Cust);

            //Task 5 - Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates
            var LastThreeP = ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3));
            var LastThreeC = CustomerList.Select(p => p.CompanyName.Substring(p.CompanyName.Length - 3));
            var res8 = LastThreeP.Zip(LastThreeC);
            //foreach (var item in res8) { Console.WriteLine(item); } 
            #endregion

            #region LINQ - Aggregate Operators
            //Task 1 - Uses Count to get the number of odd numbers in the array
            int[] Arr3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var r1 = Arr3.Count(d => d % 2 != 0);

            //Task 2 - Return a list of customers and how many orders each has.
            var r2 = CustomerList.Select(p => new { p.CompanyName, OrderCount = p.Orders.Count() });

            //Task 3 -  Return a list of categories and how many products each has
            var r3 = ProductList.GroupBy(p => p.Category)
                                 .Select(g => new { Category = g.Key, ProductCount = g.Count()});
            //Task 4 - Get the total of the numbers in an array.
            int[] Arr4 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var r4 = Arr4.Sum();
            //Console.WriteLine(r4);

            //Task 6 - Get the total units in stock for each product category
            var r5 = ProductList.GroupBy(p => p.Category)
                .Select(g => new { Category = g.Key, TotalUnitInStock = g.Sum(p => p.UnitsInStock) });

            //Task 8 - Get the cheapest price among each category's products
            var r6 = ProductList.GroupBy(p => p.Category)
                .Select(g => new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) });

            //Task 11 - Get the most expensive price among each category's products.
            var r7 = ProductList.GroupBy(p => p.Category)
                .Select(g => new { Category = g.Key, MostExpensive = g.Max(p => p.UnitPrice) });

            //Task 12 - Get the products with the most expensive price in each category
            var r8 = ProductList.GroupBy(p => p.Category)
                .Select(g => new { Category = g.Key, Products = g.Where(p => p.UnitPrice == g.Max(p => p.UnitPrice)) });

            //Task 14 - Get the average price of each category's products.
            var r9 = ProductList.GroupBy(p => p.Category)
                .Select(g => new { Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice) });

            #endregion

            #region LINQ - Ordering Operators
            //Task 1 - Sort a list of products by name
            var sortlist = ProductList.OrderBy(p => p.ProductName);

            //Task 2 - Uses a custom comparer to do a case-insensitive sort of the words in an array
            string[] ArrCustom = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortWord = ArrCustom.OrderBy(w => w);

            //Task 3 - Sort a list of products by units in stock from highest to lowest.
            var SortList = ProductList.OrderByDescending(p => p.UnitsInStock);

            //Task 4 - Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            string[] ArrSort = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var sortArr = ArrSort.OrderBy(w => w.Length).ThenBy(w => w);

            //Task 5 - Sort first by word length and then by a case-insensitive sort of the words in an array
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var SortWord = words.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

            //Task 6 - Sort a list of products, first by category, and then by unit price, from highest to lowest.
            var sortprod = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //Task 7 - Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            string[] ArrFruit = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortFruit = ArrFruit.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);

            //Task 8 - Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            string[] ArrNum = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var sortNum = ArrNum.Where(p => p[1] == 'i').Reverse();
            #endregion

            #region LINQ - Partitioning Operators
            //Task 1 - Get the first 3 orders from customers in Washington
            var getThree = CustomerList.Where(c => c.Region == "WA").SelectMany(o => o.Orders).Take(3);

            //Task 2 - Get all but the first 2 orders from customers in Washington
            var getAll = CustomerList.Where(c => c.Region == "WA").SelectMany(o => o.Orders).Skip(2);

            //Task 3 - Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var numbersFilter = numbers.TakeWhile((n, i) => n > i).Select(n => n);

            //Task 4 - Get the elements of the array starting from the first element divisible by 3.
            numbersFilter = numbers.SkipWhile(n => n % 3 != 0);

            //Task 5 - Get the elements of the array starting from the first element less than its position.
            numbersFilter = numbers.SkipWhile((n, i) => n > i);

            #endregion

            #region LINQ - Quantifiers
            //Task 2 - Return a grouped a list of products only for categories that have at least one product that is out of stock.
            var groupPro = ProductList.GroupBy(g => g.Category)
                                      .Where(g => g.Any(p => p.UnitsInStock == 0))
                                      .Select(g => new {Category = g.Key, Products = g});

            //Task 3 - Return a grouped a list of products only for categories that have all of their products in stock
            groupPro = ProductList.GroupBy(g => g.Category)
                                  .Where(g => g.All(p => p.UnitsInStock > 0))
                                  .Select(g => new { Category = g.Key, Products = g });
            #endregion

            #region LINQ - Grouping Operators
            // Use group by to partition a list of numbers by their remainder when divided by 5
            int[] numbersG = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 10, 11, 12, 13, 14 };
            var numRem = numbersG.GroupBy(n => n % 5);
            foreach (var number in numRem)
            {
                Console.WriteLine($"Numbers with a remainder of {number.Key} when divided by 5:");
                foreach (var num in number)
                {
                    Console.WriteLine(num);
                }
            }
            #endregion





        }
    }
}
