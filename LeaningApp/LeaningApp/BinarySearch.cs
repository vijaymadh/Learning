using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaningApp
{
    class BinarySearch
    {
        static BinarySearch _binarySearch;
        BinarySearch()
        {

        }

        public static BinarySearch GetInstance()
        {
            _binarySearch = _binarySearch == null ? new BinarySearch() : _binarySearch;
            return _binarySearch;
        }

        int SearchValue(int valueToFind, int[] arr, int startIndex, int EndIndex)
        {
            var midIndex = startIndex + EndIndex / 2;
            if (arr[midIndex] == valueToFind) return midIndex;
            if (midIndex < 0) return -1;
            if (arr[midIndex] > valueToFind)
            {
                return SearchValue(valueToFind, arr, 0, midIndex);
            }
            else
            {
                return SearchValue(valueToFind, arr, midIndex, arr.Length - 1);
            }
        }

        internal void FindIndex(int valueToFind)
        {
            int[] arr = { 1, 3, 4, 5, 6, 8, 9, 10 };
            var index = SearchValue(valueToFind, arr, 0, arr.Length - 1);
            Console.WriteLine($"Index for {valueToFind} is {index}");
        }
    }
}
