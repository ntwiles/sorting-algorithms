using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Sorting
{
    public class SelectionSort : ISorter
    {
        public int[] Sort(int[] unsorted)
        {
            int[] sorted = new int[] { };

            while (unsorted.Length > 0)
            {
                int lowestValueIndex = ArrayHelpers.FindLowestIndex(unsorted);
                int lowestValue = unsorted[lowestValueIndex];

                unsorted = ArrayHelpers.RemoveAt(unsorted, lowestValueIndex);
                sorted = ArrayHelpers.Append(sorted, lowestValue);
            }

            return sorted;
        }
    }
}
