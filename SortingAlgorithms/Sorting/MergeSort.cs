using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Sorting
{
    public class MergeSort : ISorter
    {
        public int[] Sort(int[] array)
        {
            mergeSort(array, 0, array.Length - 1);
            return array;
        }

        private void mergeSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;

                mergeSort(array, low, mid);
                mergeSort(array, mid + 1, high);

                merge(array, low, mid, high);
            }
        }

        private void merge(int[] array, int low, int mid, int high)
        {
            int sizeLeft = mid - low + 1;
            int sizeRight = high - mid;

            int[] tempLeft = new int[sizeLeft];
            int[] tempRight = new int[sizeRight];

            for (int i = 0; i < sizeLeft; i++)
            {
                tempLeft[i] = array[low + i];
            }

            for (int i = 0; i < sizeRight; i++)
            {
                tempRight[i] = array[mid + 1 + i];
            }

            int currentLeftIndex = 0;
            int currentRightIndex = 0;

            for (int i = low; i <= high; i++)
            {
                if (currentRightIndex >= tempRight.Length)
                {
                    addRemaining(array, tempLeft, i, currentLeftIndex);
                    break;
                }
                else if (currentLeftIndex >= tempLeft.Length)
                {
                    addRemaining(array, tempRight, i, currentRightIndex);
                    break;
                }
                else
                {

                    int currentLeft = tempLeft[currentLeftIndex];
                    int currentRight = tempRight[currentRightIndex];

                    if (currentLeft < currentRight)
                    {
                        array[i] = currentLeft;
                        currentLeftIndex++;
                    }
                    else
                    {
                        array[i] = currentRight;
                        currentRightIndex++;
                    }
                }
            }

        }

        private void addRemaining(int[] array, int[] subArray, int startIndex, int subArrayStartIndex)
        {
            for (int i = 0; i < subArray.Length - subArrayStartIndex; i++)
            {
                array[startIndex + i] = subArray[subArrayStartIndex + i];
            }
        }
    }
}
