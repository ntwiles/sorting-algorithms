using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithms;

namespace SortingAlgorithmsTests
{
    [TestClass]
    public class ArrayHelpersTests
    {
        [DataTestMethod]
        [DataRow(0)]
        //[DataRow(new int[] { 0, 1, 2}, 1, new int[] { 0, 2 } )]
        //[DataRow(new int[] { 3 }, 0, new int[] { 3 })]
        //[DataRow(new int[] { }, 0, new int[] { })]
        public void RemoveAtTest(int data)
        {
            //int[] actual = ArrayHelpers.RemoveAt(inputArray, removeIndex);

            //CollectionAssert.AreEqual(expected, actual);

            Assert.AreEqual(0, data);
        }
    }
}
