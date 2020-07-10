using Microsoft.VisualStudio.TestTools.UnitTesting;

using SortingAlgorithms.Sorting;

namespace SortingAlgorithmTests.Sorting
{
    [TestClass]
    public class ArrayHelperTests
    {
        [TestMethod]
        [DataRow(new int[] { 0, 1, 2 }, 1 , 7, new int[] { 0, 7, 1, 2})]
        [DataRow(new int[] { 0, 1, 2 }, 2, 7, new int[] { 0, 1, 7, 2 })]
        [DataRow(new int[] { 1 }, 0, 8, new int[] { 8, 1 })]
        [DataRow(new int[] { }, 0, 7, new int[] { 7 })]
        public void InsertAtTest(int[] inputArray, int insertIndex, int value, int[] expected)
        {
            int[] actual = ArrayHelpers.InsertAt(inputArray, insertIndex, value);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 0, 1, 2 }, 0, new int[] { 1, 2 })]
        [DataRow(new int[] { 0, 1, 2},  1, new int[] { 0, 2})]
        [DataRow(new int[] { 0, 1, 2 }, 2, new int[] { 0, 1 })]
        [DataRow(new int[] { 0 },       0, new int[] { })]
        public void RemoveAtTest(int[] inputArray, int removeIndex, int[] expected)
        {
            int[] actual = ArrayHelpers.RemoveAt(inputArray, removeIndex);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 0, 1, 2 }, 0, new int[] { 0, 1, 2, 0})]
        [DataRow(new int[] { },         7, new int[] { 7 })]
        public void AppendTest(int[] inputArray, int value, int[] expected)
        {
            int[] actual = ArrayHelpers.Append(inputArray, value);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
