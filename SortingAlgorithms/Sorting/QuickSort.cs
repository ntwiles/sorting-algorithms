using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Sorting
{
    public class QuickSort : ISorter
    {
        public int[] Sort(int[] array)
        {
            quickSort(array, 0, array.Length - 1);
            return array;
        }

        private void quickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotPoint = partition(array, low, high);

                quickSort(array, low, pivotPoint - 1);
                quickSort(array, pivotPoint + 1, high);
            }
        }

        private static int partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int lastLow = low;

            for (int i = low; i <= high; i++)
            {
                if (array[i] <= pivot)
                {
                    int temp = array[lastLow];
                    array[lastLow] = array[i];
                    array[i] = temp;
                    lastLow++;
                }
            }

            return lastLow - 1;
        }
    }
}
