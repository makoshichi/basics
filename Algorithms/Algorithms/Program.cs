using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithm math = new Algorithm();
            Sorting sorting = new Sorting();

            Console.WriteLine(math.RecursiveFactorial(4)); // 24

            //Console.WriteLine(math.DiagonalDifference(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 9, 7, 9 } })); // 2

            //int[] triple = math.TripletStupid(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 });
            //Console.WriteLine($"[{triple[0]}, {triple[1]}]"); // [1, 1]

            //int[] minMaxSum = math.MinMaxSum(new int[] { 1, 2, 3, 4, 5 });
            //Console.WriteLine($"[{minMaxSum[0]}, {minMaxSum[1]}]"); // [10, 14]

            //int[] orderedArray = math.OrderAscending(new int[] { 5, 4, 3, 1, 5 });

            int[] orderedArray = new int[] { 5, 4, 3, 1, 5 };
            sorting.BubbleSort(orderedArray);

            int[] fasterOrderedArray = new int[] { 5, 4, 3, 1, 5, 8, 6, 9, 0 };
            sorting.SelectionSort(fasterOrderedArray);

            int[] fastestOrderedArray = new int[] { 5, 4, 3, 1, 5, 8, 6, 9, 0 };
            sorting.MergeSort(fasterOrderedArray, 0, fasterOrderedArray.Length);

            Console.WriteLine(math.BinarySearch(fasterOrderedArray, 8));

            Console.ReadKey();
        }
    }
}
