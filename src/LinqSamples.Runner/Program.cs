using System;

namespace LinqSamples.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Comment or uncomment the method calls below to run or not
            //

            #region GroupingOperators

            var groupingOperators = new GroupingOperators();

            // This sample uses group by to partition a list of numbers by their remainder when divided by 5.
            //groupingOperators.DataSetLinq40();

            // This sample uses group by to partition a list of words by their first letter.
            //groupingOperators.DataSetLinq41();    

            // This sample uses group by to partition a list of products by category.
            //groupingOperators.DataSetLinq42();    

            // This sample uses group by to partition a list of each customer's orders, first by year, and then by month.
            //groupingOperators.DataSetLinq43();    

            // This sample uses GroupBy to partition trimmed elements of an array using a custom comparer 
            // that matches words that are anagrams of each other.
            //groupingOperators.DataSetLinq44();    

            // This sample uses GroupBy to partition trimmed elements of an array using a custom comparer that matches words 
            // that are anagrams of each other, and then converts the results to uppercase.
            //groupingOperators.DataSetLinq45();   

            #endregion

            #region SetOperators
            var setOperators = new SetOperators();

            // This sample uses Distinct to remove  duplicate  elements in a sequence of factors of 300
            //setOperators.Linq46();

            // This sample uses Distinct to find the unique Category names
            //setOperators.Linq47(); 

            // This sample uses Union to create  one sequence that contains the unique values from both 
            // arrays
            //setOperators.Linq48(); 

            // This sample uses the Union method to create  one sequence that contains the unique first 
            // letter from both product and customer names. Union is only available through method 
            // syntax
            //setOperators.Linq49(); 

            // This sample uses Intersect to create one sequence that contains the common values shared 
            // by both arrays
            //setOperators.Linq50(); 

            // This sample uses Intersect  to create one sequence that contains the common first letter 
            // from both product and customer names
            //setOperators.Linq51(); 

            // This sample uses Except to create a sequence that contains the values from numbersA that 
            // are not also in numbersB
            //setOperators.Linq52(); 

            // This sample uses Except to create one  sequence that contains the 1st letters of product 
            // names that are not also first letters of customer names 
            //setOperators.Linq53(); 
            #endregion

            #region ConversionOperators

            var conversionOps = new ConversionOperators();

            // This sample uses ToArray to immediately evaluate a sequence into an array
            //conversionOps.Linq54();

            // This sample uses ToList to immediately evaluate a sequence into a List<T>
            //conversionOps.Linq55(); 

            // This sample uses ToDictionary to immediately  evaluate a  sequence  and a 
            // related key expression into a dictionary
            //conversionOps.Linq56(); 

            // This sample uses OfType to return only the elements of the array that are 
            // of type double
            //conversionOps.Linq57(); 

            #endregion

            #region AggregateOperators

            var aggregateOps = new AggregateOperators();
            // This sample uses Count to get the number of unique prime factors of 300
            //aggregateOps.Linq73();

            // This sample uses Count to get the number of odd ints in the array
            //aggregateOps.Linq74(); 

            // This sample uses Count to return a list of customers and how many orders each has
            //aggregateOps.Linq76();

            // This sample uses Count to return a list of categories and how many products each has
            //aggregateOps.Linq77(); 

            // This sample uses Sum to add all the numbers in an array
            //aggregateOps.Linq78(); 

            // This sample uses Sum to get the total number of characters of all words in the array
            //aggregateOps.Linq79(); 

            // This sample uses Sum to get the total units in stock for each product category
            //aggregateOps.Linq80(); 

            // This sample uses Min to get the lowest number in an array
            //aggregateOps.Linq81(); 

            // This sample uses Min to get the length of the shortest word in an array
            //aggregateOps.Linq82(); 

            // This sample uses Min to get the cheapest price among each category's products
            //aggregateOps.Linq83(); 

            // This sample uses Min to get the products with the lowest price in each category
            //aggregateOps.Linq84(); 

            // This sample uses Max to get the highest number in an array. Note that the method 
            // returns a single value
            //aggregateOps.Linq85(); 

            // This sample uses Max to get the length of the longest word in an array
            //aggregateOps.Linq86(); 

            // This sample uses Max to get the most expensive price among each category's products
            //aggregateOps.Linq87(); 

            // This sample uses Max to get the products with the most expensive price in each category
            //aggregateOps.Linq88(); 

            // This sample uses Average to get the average of all numbers in an array
            //aggregateOps.Linq89(); 

            // This sample uses Average to get the average length of the words in the array
            //aggregateOps.Linq90(); 

            // This sample uses Average to get the average price of each category's products
            //aggregateOps.Linq91(); 

            // This sample uses Aggregate to create a running product on the array that calculates 
            // the total product of all elements            
            //aggregateOps.Linq92(); 

            // This sample uses Aggregate to create a running account balance that subtracts each 
            // withdrawal from the initial balance of 100, as long as the balance never drops below 0
            //aggregateOps.Linq93(); 

            #endregion

            #region CustomSequenceOperators

            var customSeqOps = new CustomSequenceOperatorsCore();

            // This sample uses a user-created sequence operator, Combine, to calculate the dot product of two vectors.
            //customSeqOps.DataSetLinq98();

            #endregion

            #region QueryExecution

            var queryExecution = new QueryExecution();

            // The following sample shows how query execution is deferred until the query is 
            // enumerated at a foreach statement
            //queryExecution.Linq99();

            // The following sample shows how queries can be executed immediately, and their 
            // results stored in memory, with methods such as ToList
            //queryExecution.Linq100();

            // The following sample shows how, because of deferred execution, queries can be 
            // used again after data changes and will then operate on the new data 
            //queryExecution.Linq101();        

            #endregion

        }
    }
}
