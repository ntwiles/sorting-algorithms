using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Sorting
{
    public static class ArrayHelpers
    {
        public static bool Contains(int[] array, int search, out int indexOf)
        {
            indexOf = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == search)
                {
                    indexOf = i;
                    return true;
                }
            }

            return false;
        }

        public static int[] InsertAt(int[] inputArray, int insertIndex, int value)
        {
            if (inputArray.Length == 0) return new int[] { value };

            int[] outputArray = new int[inputArray.Length + 1];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i < insertIndex)
                {
                    outputArray[i] = inputArray[i];
                }
                else 
                {
                    outputArray[i + 1] = inputArray[i];
                }

                if (i == insertIndex)
                {
                    outputArray[i] = value;
                }
            }

            inputArray = outputArray;
            return inputArray;
        }

        public static int[] RemoveAt(int[] inputArray, int removeIndex)
        {
            int[] outputArray = new int[inputArray.Length - 1];

            for (int i = 0; i < outputArray.Length; i++)
            {
                if (i < removeIndex)
                {
                    outputArray[i] = inputArray[i];
                }
                else
                {
                    outputArray[i] = inputArray[i + 1];
                }
            }

            inputArray = outputArray;
            return inputArray;
        }

        public static int[] Append(int[] inputArray, int value)
        {
            int[] outputArray = new int[inputArray.Length + 1];

            for (int i = 0; i < inputArray.Length; i++)
            {
                outputArray[i] = inputArray[i];
            }

            outputArray[outputArray.Length - 1] = value;

            inputArray = outputArray;
            return inputArray;
        }

        public static int FindFirstHigherIndex(int[] array, int search)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > search)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int FindLowestIndex(int[] array)
        {
            int lowestIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[lowestIndex])
                {
                    lowestIndex = i;
                }
            }

            return lowestIndex;
        }
    }
}
