using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSorter.Utils
{
    public class ArrayHelper
    {
        private const int minValue = 0;
        private const int maxValue = 1000000000;

        //Created so that it`s possible to write test for it
        public int[] GenerateArray(int size = 100000)
        {
            int[] arr = new int[size];
            var rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(minValue, maxValue);
            }
            return arr;
        }

        public void WriteToFile(int[] arr, int fileNum)
        {
            File.WriteAllText($@".\arr{fileNum}.txt", string.Join(" ", arr));
        }

        public bool CompareArr(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }

            return true;
        }

        public int[] ReadArray(int i)
        {
            return System.IO.File
                .ReadAllText($@".\arr{i}.txt").Split(' ').Select(y => int.Parse(y)).ToArray();
        }

        public void GenerateArrayAndWriteToFile(int i)
        {
            var arr = GenerateArray();
            WriteToFile(arr, i);
        }
    }
}
