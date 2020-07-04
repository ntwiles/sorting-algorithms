using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Sorting
{
    public class BubbleSort : ISorter
    {
        public int[] Sort(int[] array)
        {
            bool madeSwap = true;

            while (madeSwap)
            {
                madeSwap = false;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    int current = array[i];
                    int next = array[i + 1];

                    if (next < current)
                    {
                        array[i + 1] = current;
                        array[i] = next;
                        madeSwap = true;
                    }
                }
            }

            return array;
        }
    }
}
