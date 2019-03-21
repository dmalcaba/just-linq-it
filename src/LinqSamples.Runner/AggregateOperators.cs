using LinqSamples.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSamples.Runner
{
    public partial class LinqSamples : LinqSampleBase
    {
        /// <summary>
        /// This sample uses Count to get the number of unique prime factors of 300.
        /// </summary>
        public void Linq73()
        {
            int[] primeFactorsOf300 = { 2, 2, 3, 5, 5 };

            int uniqueFactors = primeFactorsOf300.Distinct().Count();

            Console.WriteLine("There are {0} unique prime factors of 300.", uniqueFactors);
        }

        /// <summary>
        /// This sample uses Count to get the number of odd ints in the array.
        /// </summary>
        public void Linq74()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int oddNumbers = numbers.Count(n => n % 2 == 1);

            Console.WriteLine("There are {0} odd numbers in the list.", oddNumbers);
        }

        /// <summary>
        /// This sample uses Count to return a list of customers and how many orders each has.
        /// </summary>
        public void Linq76()
        {
            List<Customer> customers = GetCustomerList();

            var orderCounts =
                from cust in customers
                select new { cust.CustomerID, OrderCount = cust.Orders.Count() };

            ObjectDumper.Write(orderCounts);
        }

        /// <summary>
        /// This sample uses Count to return a list of categories and how many products each has.
        /// </summary>
        public void Linq77()
        {
            List<Product> products = GetProductList();

            var categoryCounts =
                from prod in products
                group prod by prod.Category into prodGroup
                select new { Category = prodGroup.Key, ProductCount = prodGroup.Count() };

            ObjectDumper.Write(categoryCounts);
        }

        /// <summary>
        /// This sample uses Sum to add all the numbers in an array.
        /// </summary>
        public void Linq78()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            double numSum = numbers.Sum();

            Console.WriteLine("The sum of the numbers is {0}.", numSum);
        }

        /// <summary>
        /// This sample uses Sum to get the total number of characters of all words in the array.
        /// </summary>
        public void Linq79()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            double totalChars = words.Sum(w => w.Length);

            Console.WriteLine("There are a total of {0} characters in these words.", totalChars);
        }

        /// <summary>
        /// This sample uses Sum to get the total units in stock for each product category.
        /// </summary>
        public void Linq80()
        {
            List<Product> products = GetProductList();

            var categories =
                from prod in products
                group prod by prod.Category into prodGroup
                select new { Category = prodGroup.Key, TotalUnitsInStock = prodGroup.Sum(p => p.UnitsInStock) };

            ObjectDumper.Write(categories);
        }

        /// <summary>
        /// This sample uses Min to get the lowest number in an array.
        /// </summary>
        public void Linq81()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int minNum = numbers.Min();

            Console.WriteLine("The minimum number is {0}.", minNum);
        }

        /// <summary>
        /// This sample uses Min to get the length of the shortest word in an array.
        /// </summary>
        public void Linq82()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            int shortestWord = words.Min(w => w.Length);

            Console.WriteLine("The shortest word is {0} characters long.", shortestWord);
        }

        /// <summary>
        /// This sample uses Min to get the cheapest price among each category's products.
        /// </summary>
        public void Linq83()
        {
            List<Product> products = GetProductList();

            var categories =
                from prod in products
                group prod by prod.Category into prodGroup
                select new { Category = prodGroup.Key, CheapestPrice = prodGroup.Min(p => p.UnitPrice) };

            ObjectDumper.Write(categories);
        }

        /// <summary>
        /// This sample uses Min to get the products with the lowest price in each category.
        /// </summary>
        public void Linq84()
        {
            List<Product> products = GetProductList();

            var categories =
                from prod in products
                group prod by prod.Category into prodGroup
                let minPrice = prodGroup.Min(p => p.UnitPrice)
                select new { Category = prodGroup.Key, CheapestProducts = prodGroup.Where(p => p.UnitPrice == minPrice) };

            ObjectDumper.Write(categories, 1);
        }

        /// <summary>
        /// This sample uses Max to get the highest number in an array. Note that the method returns a single value.
        /// </summary>
        public void Linq85()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int maxNum = numbers.Max();

            Console.WriteLine("The maximum number is {0}.", maxNum);
        }

        /// <summary>
        /// This sample uses Max to get the length of the longest word in an array.
        /// </summary>
        public void Linq86()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            int longestLength = words.Max(w => w.Length);

            Console.WriteLine("The longest word is {0} characters long.", longestLength);
        }

        /// <summary>
        /// This sample uses Max to get the most expensive price among each category's products.
        /// </summary>
        public void Linq87()
        {
            List<Product> products = GetProductList();

            var categories =
                from prod in products
                group prod by prod.Category into prodGroup
                select new { Category = prodGroup.Key, MostExpensivePrice = prodGroup.Max(p => p.UnitPrice) };

            ObjectDumper.Write(categories);
        }

        /// <summary>
        /// This sample uses Max to get the products with the most expensive price in each category.
        /// </summary>
        public void Linq88()
        {
            List<Product> products = GetProductList();

            var categories =
                from prod in products
                group prod by prod.Category into prodGroup
                let maxPrice = prodGroup.Max(p => p.UnitPrice)
                select new { Category = prodGroup.Key, MostExpensiveProducts = prodGroup.Where(p => p.UnitPrice == maxPrice) };

            ObjectDumper.Write(categories, 1);
        }

        /// <summary>
        /// This sample uses Average to get the average of all numbers in an array.
        /// </summary>
        public void Linq89()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            double averageNum = numbers.Average();

            Console.WriteLine("The average number is {0}.", averageNum);
        }

        /// <summary>
        /// This sample uses Average to get the average length of the words in the array.
        /// </summary>
        public void Linq90()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            double averageLength = words.Average(w => w.Length);

            Console.WriteLine("The average word length is {0} characters.", averageLength);
        }

        /// <summary>
        /// This sample uses Average to get the average price of each category's products.
        /// </summary>
        public void Linq91()
        {
            List<Product> products = GetProductList();

            var categories =
                from prod in products
                group prod by prod.Category into prodGroup
                select new { Category = prodGroup.Key, AveragePrice = prodGroup.Average(p => p.UnitPrice) };

            ObjectDumper.Write(categories);
        }

        /// <summary>
        /// This sample uses Aggregate to create a running product on the array that calculates the total product of all elements.
        /// </summary>
        public void Linq92()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            double product = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);

            Console.WriteLine("Total product of all numbers: {0}", product);
        }

        /// <summary>
        /// This sample uses Aggregate to create a running account balance that
        /// subtracts each withdrawal from the initial balance of 100, as long as
        /// the balance never drops below 0.
        /// </summary>
        public void Linq93()
        {
            double startBalance = 100.0;

            int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };

            double endBalance =
                attemptedWithdrawals.Aggregate(startBalance,
                    (balance, nextWithdrawal) =>
                        ((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance));

            Console.WriteLine("Ending balance: {0}", endBalance);
        }
    }
}
