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

            #region SetOperators
            var setOperators = new SetOperators();

            // This sample uses Distinct to remove  duplicate  elements in a sequence of factors of 300
            setOperators.Linq46();

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
