using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Sorting
{
    public class InsertionSort : ISorter
    {
        public int[] Sort(int[] unsorted)
        {
            int[] sorted = new int[] { };

            for (int i = 0; i < unsorted.Length; i++)
            {
                if (sorted.Length == 0 || unsorted[i] < sorted[sorted.Length - 1])
                {
                    int insertPoint = ArrayHelpers.FindFirstHigherIndex(sorted, unsorted[i]);
                    sorted = ArrayHelpers.InsertAt(sorted, insertPoint, unsorted[i]);
                }
                else
                {
                    sorted = ArrayHelpers.Append(sorted, unsorted[i]);
                }
            }

            return sorted;
        }
    }
}
