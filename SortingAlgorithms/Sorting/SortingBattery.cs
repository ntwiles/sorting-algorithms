using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Sorting
{
    public class SortingBattery
    {
        private static List<ISorter> sorters;

        static SortingBattery()
        {
            sorters = new List<ISorter>();
            sorters.Add(new BubbleSort());
            sorters.Add(new SelectionSort());
            sorters.Add(new InsertionSort());
            sorters.Add(new MergeSort());
            sorters.Add(new QuickSort());
        }

        public static List<ISorter> GetAllSorters()
        {
            return sorters;
        }
    }
}
