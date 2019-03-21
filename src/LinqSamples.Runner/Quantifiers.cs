using System;
using System.ComponentModel;
using System.Linq;

namespace LinqSamples.Runner
{
    public class Quantifiers : LinqSampleBase
    {
        [Category("Quantifiers")]
        [Description("This sample uses Any to determine if any of the words in the array " +
             "contain the substring 'ei'.")]
        public void Linq67()
        {
            string[] words = { "believe", "relief", "receipt", "field" };

            bool iAfterE = words.Any(w => w.Contains("ei"));

            Console.WriteLine("There is a word in the list that contains 'ei': {0}", iAfterE);
        }

        [Category("Quantifiers")]
        [Description("This sample uses Any to return a grouped a list of products only for categories " +
                     "that have at least one product that is out of stock.")]
        public void Linq69()
        {
            var productGroups =
                from prod in productList
                group prod by prod.Category into prodGroup
                where prodGroup.Any(p => p.UnitsInStock == 0)
                select new { Category = prodGroup.Key, Products = prodGroup };

            ObjectDumper.Write(productGroups, 1);
        }

        [Category("Quantifiers")]
        [Description("This sample uses All to determine whether an array contains " +
                     "only odd numbers.")]
        public void Linq70()
        {
            int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };

            bool onlyOdd = numbers.All(n => n % 2 == 1);

            Console.WriteLine("The list contains only odd numbers: {0}", onlyOdd);
        }

        [Category("Quantifiers")]
        [Description("This sample uses All to return a grouped a list of products only for categories " +
                     "that have all of their products in stock.")]
        public void Linq72()
        {
            var productGroups =
                from prod in productList
                group prod by prod.Category into prodGroup
                where prodGroup.All(p => p.UnitsInStock > 0)
                select new { Category = prodGroup.Key, Products = prodGroup };

            ObjectDumper.Write(productGroups, 1);
        }
    }
}
