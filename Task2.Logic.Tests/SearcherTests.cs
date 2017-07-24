using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2.Logic.Tests
{
    [TestFixture]
    public class SearcherTests
    {

        [Test]
        public void BinarySearch_SearchFromArea_InIntArr_WithDelegate_ReturnsIndex1()
        {
            int[] arr = { 12, 45, 1, 2, 4 };

            Comparison<int> delComparison = (x, y) => x.CompareTo(y);

            Assert.AreEqual(1, Searcher.BinarySearch(arr, 0, 2, 45, delComparison));
        }

        [Test]
        public void BinarySearch_SearchFromArea_InIntArr_WithIComparer_ReturnsIndex1()
        {
            int[] arr = { 12, 45, 1, 2, 4 };

            Comparison<int> delComparison = (x, y) => x.CompareTo(y);

            Assert.AreEqual(1, Searcher.BinarySearch(arr, 0, 2, 45, Comparer<int>.Create(delComparison)));
        }


        [Test]
        public void BinarySearch_SearchInIntArr_WithIComparer_ReturnsIndex3()
        {
            int[] arr = { 12, 45, 1, 2, 4 };

            Comparison<int> delComparison = (x, y) => x.CompareTo(y);

            Assert.AreEqual(3, Searcher.BinarySearch(arr,2, Comparer<int>.Create(delComparison)));
        }

        [Test]
        public void BinarySearch_SearchInIntArr_WithDelegate_ReturnsIndex4()
        {
            int[] arr = { 12, 45, 1, 2, 4 };

            Comparison<int> delComparison = (x, y) => x.CompareTo(y);

            Assert.AreEqual(4, Searcher.BinarySearch(arr, 4, delComparison));
        }


        [Test]
        public void BinarySearch_SearchWithoutInterfaceOrDelegate_ReturnsIndex4()
        {
            int[] arr = { 12, 45, 1, 2, 4 };

            Comparison<int> delComparison = (x, y) => x.CompareTo(y);

            Assert.AreEqual(4, Searcher.BinarySearch(arr, 4));
        }

    }
}
