/*Problem 2. IEnumerable extensions
    Implement a set of extension methods for IEnumerable<T> that implement the following group functions:
    sum, product, min, max, average.
*/

namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var collection = new HashSet<double> { 2.5, -5, 10.5, 10.5 }; // HashSet only unique elements

            Console.WriteLine("Sum of numbers is {0}", collection.SumOfEnumerable());
            Console.WriteLine("Product of numbers is {0}", collection.ProductOfEnumerable());
            Console.WriteLine("Min number is {0}", collection.MinOfEnumerable());
            Console.WriteLine("Max number is {0}", collection.MaxOfEnumerable());
            Console.WriteLine("Average of numbers is {0}", collection.AverageOfEnumerable());
        }
    }
}
