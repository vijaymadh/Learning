using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace LeaningApp
{
    class BubbleSort
    {
        static BubbleSort _bubbleSort;
        BubbleSort()
        {

        }
        public static BubbleSort GetInstance()
        {
            _bubbleSort = _bubbleSort == null ? new BubbleSort() : _bubbleSort;
            return _bubbleSort;
        }

        internal void SortArray()
        {
            int[] oldArray = {3,6,4,7,9,11,5,12,13 };
            int[] sortedArray = { };
            var tempStore=0;

            for (int i = 0; i <= oldArray.Length - 1; i++)
            {
                for (int j = 0; j <= oldArray.Length - 2; j++)
                {
                    if (oldArray[j] > oldArray[j + 1])
                    {
                        tempStore = oldArray[j + 1];
                        oldArray[j + 1] = oldArray[j];
                        oldArray[j] = tempStore;

                    }
                }
            }

            Console.WriteLine(string.Join(",",oldArray));

        }
    }
}
