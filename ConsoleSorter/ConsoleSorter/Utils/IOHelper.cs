using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSorter.Utils
{
    public class IOHelper
    {
        public int[] GreetAndGetArraysSizes()
        {
            int[] arrSizes = new int[2];
            Console.WriteLine("Hello, user! Now two arrays would be generated, please enter their sizes(first one would be sorted by Quicksort, second - be Mergesort)");

            arrSizes[0] = GetArraySize("Quicksort");
            arrSizes[1] = GetArraySize("Mergesort");

            return arrSizes;
        }

        private int GetArraySize(string sortName)
        {
            Console.WriteLine($"Please, enter the array size(Array would be sorted via {sortName}):");
            string input = Console.ReadLine();
            int size;
            if (Int32.TryParse(input, out size))
            {
                return size;
            }
            else
            {
                Console.WriteLine("Incorrect value! Try one more time");
                return GetArraySize(sortName);
            }
        }

        public void PrintArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
