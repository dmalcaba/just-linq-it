using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace LinqSamples.Runner
{
    public static class CustomSequenceOperators
    {
        public static IEnumerable<S> Combine<S>(this IEnumerable<DataRow> first, IEnumerable<DataRow> second, System.Func<DataRow, DataRow, S> func)
        {
            using (IEnumerator<DataRow> e1 = first.GetEnumerator(), e2 = second.GetEnumerator())
            {
                while (e1.MoveNext() && e2.MoveNext())
                {
                    yield return func(e1.Current, e2.Current);
                }
            }
        }
    }

    public class CustomSequenceOperatorsCore
    {
        private DataSet testDS;

        public CustomSequenceOperatorsCore()
        {
            testDS = TestHelper.CreateTestDataset();
        }

        [Category("Custom Sequence Operators")]
        [Description("This sample uses a user-created sequence operator, Combine, to calculate the " +
                     "dot product of two vectors.")]
        public void DataSetLinq98()
        {

            var numbersA = testDS.Tables["NumbersA"].AsEnumerable();
            var numbersB = testDS.Tables["NumbersB"].AsEnumerable();

            int dotProduct = numbersA.Combine(numbersB, (a, b) => a.Field<int>("number") * b.Field<int>("number")).Sum();
            Console.WriteLine("Dot product: {0}", dotProduct);
        }

    }
}
