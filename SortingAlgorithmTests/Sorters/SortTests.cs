using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using SortingAlgorithms.Sorting;

namespace SortingAlgorithmTests
{
    [TestClass]
    public abstract class SortTests
    {
        private ISorter sut;

        [TestInitialize]
        public void Setup()
        {
            sut = CreateSorter();
        }

        protected abstract ISorter CreateSorter();

        [TestMethod]
        [DataRow(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        [DataRow(new int[] { 50, 23, 9, 18, 61, 32 }, new int[] {9, 18, 23, 32, 50, 61})]
        [DataRow(new int[] { 7 }, new int[] { 7 })]
        [DataRow(new int[] { 3, 2 }, new int[] { 2, 3 })]
        [DataRow(new int[] { 3, 3 }, new int[] { 3, 3})]
        [DataRow(new int[] { 2, 3, -4, 5 }, new int[] { -4, 2, 3, 5 })]
        public void SortTest(int[] input, int[] expected)
        {
            int[] original = (int[])input.Clone();

            int[] actual = sut.Sort(input);

            string errorMessage = $"\n{sut.ToString()}";
            errorMessage += $"\nExpected {expected.ToString()} \n Got: {actual.ToString()}";

            CollectionAssert.AreEqual(expected, actual, errorMessage);
        }

        [TestClass]
        public class BubbleSortTests : SortTests
        {
            protected override ISorter CreateSorter()
            {
                return new BubbleSort();
            }
        }

        [TestClass]
        public class InsertionSortTests : SortTests
        {
            protected override ISorter CreateSorter()
            {
                return new InsertionSort();
            }
        }

        [TestClass]
        public class QuickSortTests : SortTests
        {
            protected override ISorter CreateSorter()
            {
                return new QuickSort();
            }
        }


        [TestClass]
        public class SelectionSortTests : SortTests
        {
            protected override ISorter CreateSorter()
            {
                return new SelectionSort();
            }
        }


        [TestClass]
        public class MergeSortTests : SortTests
        {
            protected override ISorter CreateSorter()
            {
                return new MergeSort();
            }
        }
    }
}
