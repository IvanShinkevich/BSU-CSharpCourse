using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleSorter.Utils;

namespace ConsoleSorter
{
    class Program
    {
        private static IOHelper ioHelper = new IOHelper();
        private static ArrayHelper arrHelper = new ArrayHelper();
        private static SortingHelper sorter = new SortingHelper();
        private static int[] arr4Quicksort;
        private static int[] arr4Mergesort;

        static void Main(string[] args)
        {
            GreetAndGenerateArrays();
            ShowAndSortArrays();
        }

        private static void ShowAndSortArrays()
        {
            PrintArrays(arr4Quicksort, arr4Mergesort);
            SortArrays(arr4Quicksort, arr4Mergesort);
            PrintDelimiter4SortedArrays();
            PrintArrays(arr4Quicksort, arr4Mergesort);
        }

        private static void PrintDelimiter4SortedArrays()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("Sorted arrays");
            Console.WriteLine("----------------------");
        }

        private static void GreetAndGenerateArrays()
        {
            int[] arrSizes = ioHelper.GreetAndGetArraysSizes();
            arr4Quicksort = arrHelper.GenerateArray(arrSizes[0]);
            arr4Mergesort = arrHelper.GenerateArray(arrSizes[1]);
        }

        private static void PrintArrays(int[] arr4Quicksort, int[] arr4Mergesort)
        {
            Console.WriteLine("Array for Quicksort:");
            ioHelper.PrintArray(arr4Quicksort);
            Console.WriteLine("Array for Mergesort:");
            ioHelper.PrintArray(arr4Mergesort);
        }

        private static void SortArrays(int[] arr4Quicksort, int[] arr4Mergesort)
        {
            sorter.Quicksort(arr4Quicksort);
            sorter.MergeSort(arr4Mergesort);
        }
    }
}
