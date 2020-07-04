using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms.Demo
{
    public static class RandomArrayGenerator
    {
        public static int[] GenerateUnsorted(int size)
        {
            int[] sorted = new int[size];

            for (int i = 0; i < sorted.Length; i++)
            {
                sorted[i] = i;
            }

            var rand = new Random();
            return sorted.OrderBy(x => rand.Next()).ToArray();
        }
    }
}
