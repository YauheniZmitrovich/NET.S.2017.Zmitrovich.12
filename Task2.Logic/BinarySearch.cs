using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Logic
{
    /// <summary>
    /// Helps to find something somewhere.
    /// </summary>
    public static class Searcher
    {
        /// <summary>
        ///  Searches a range of elements in a one-dimensional sorted array for a value, using
        ///  the specified System.Collections.Generic.IComparer generic interface.
        /// </summary>
        /// <typeparam name="T">  The type of the elements of the array. </typeparam>
        /// <param name="arr"> The sorted one-dimensional array to search. </param>
        /// <param name="index"> The starting index of the range to search. </param>
        /// <param name="count"> The length of the range to search. </param>
        /// <param name="item"> The object to search for. </param>
        /// <param name="comparer">  The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements.-or- null to use the System.IComparable implementation of each element.
        /// </param>
        /// <returns>
        ///  The index of the specified value in the specified array, if value is found. If
        ///  value is not found and value is less than one or more elements in array, a negative
        ///  number which is the bitwise complement of the index of the first element that
        ///  is larger than value. If value is not found and value is greater than any of
        ///  the elements in array, a negative number which is the bitwise complement of (the
        ///  index of the last element plus 1).
        /// </returns>
        public static int BinarySearch<T>(T[] arr, int index, int count, T item, IComparer<T> comparer)
        {
            if(arr==null)
                throw new ArgumentNullException(nameof(arr));
            if (index < 0)
                throw new ArgumentException("The index can't be less than zero.");
            if (count < 0)
                throw new ArgumentException("The count can't be less than zero.");
            if (arr.Length < index + count)
                throw new ArgumentException("The search area more than current area.");

            return Array.BinarySearch<T>(arr, index, count, item, comparer);
        }

        /// <summary>
        ///  Searches a range of elements in a one-dimensional sorted array for a value, using <see cref="Comparison{T}"/>.
        /// </summary>
        /// <typeparam name="T">  The type of the elements of the array. </typeparam>
        /// <param name="arr"> The sorted one-dimensional array to search. </param>
        /// <param name="index"> The starting index of the range to search. </param>
        /// <param name="count"> The length of the range to search. </param>
        /// <param name="item"> The object to search for. </param>
        /// <param name="delComparison">  
        /// The <see cref="Comparison{T}"/> implementation to use when comparing elements.
        /// </param>
        /// <returns>
        ///  The index of the specified value in the specified array, if value is found. If
        ///  value is not found and value is less than one or more elements in array, a negative
        ///  number which is the bitwise complement of the index of the first element that
        ///  is larger than value. If value is not found and value is greater than any of
        ///  the elements in array, a negative number which is the bitwise complement of (the
        ///  index of the last element plus 1).
        /// </returns>
        public static int BinarySearch<T>(T[] arr, int index, int count, T item, Comparison<T> delComparison) =>
            BinarySearch(arr, index, count, item, Comparer<T>.Create(delComparison));


        /// <summary>
        ///  Searches a range of elements in a one-dimensional sorted array for a value.
        /// </summary>
        /// <typeparam name="T">  The type of the elements of the array. </typeparam>
        /// <param name="arr"> The sorted one-dimensional array to search. </param>
        /// <param name="item"> The object to search for. </param>
        /// <returns>
        ///  The index of the specified value in the specified array, if value is found. If
        ///  value is not found and value is less than one or more elements in array, a negative
        ///  number which is the bitwise complement of the index of the first element that
        ///  is larger than value. If value is not found and value is greater than any of
        ///  the elements in array, a negative number which is the bitwise complement of (the
        ///  index of the last element plus 1).
        /// </returns>
        public static int BinarySearch<T>(T[] arr, T item) =>
            BinarySearch(arr, 0, arr.Length, item, (IComparer<T>)null);


        /// <summary>
        ///  Searches a range of elements in a one-dimensional sorted array for a value, using
        ///  the specified System.Collections.Generic.IComparer generic interface.
        /// </summary>
        /// <typeparam name="T">  The type of the elements of the array. </typeparam>
        /// <param name="arr"> The sorted one-dimensional array to search. </param>
        /// <param name="item"> The object to search for. </param>
        /// <param name="comparer">  The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements.-or- null to use the System.IComparable implementation of each element.
        /// </param>
        /// <returns>
        ///  The index of the specified value in the specified array, if value is found. If
        ///  value is not found and value is less than one or more elements in array, a negative
        ///  number which is the bitwise complement of the index of the first element that
        ///  is larger than value. If value is not found and value is greater than any of
        ///  the elements in array, a negative number which is the bitwise complement of (the
        ///  index of the last element plus 1).
        /// </returns>
        public static int BinarySearch<T>(T[] arr, T item, IComparer<T> comparer) =>
            BinarySearch(arr, 0, arr.Length, item, comparer);

        /// <summary>
        ///  Searches a range of elements in a one-dimensional sorted array for a value, using <see cref="Comparison{T}"/>.
        /// </summary>
        /// <typeparam name="T">  The type of the elements of the array. </typeparam>
        /// <param name="arr"> The sorted one-dimensional array to search. </param>
        /// <param name="item"> The object to search for. </param>
        /// <param name="delComparison">  
        /// The <see cref="Comparison{T}"/> implementation to use when comparing elements.
        /// </param>
        /// <returns>
        ///  The index of the specified value in the specified array, if value is found. If
        ///  value is not found and value is less than one or more elements in array, a negative
        ///  number which is the bitwise complement of the index of the first element that
        ///  is larger than value. If value is not found and value is greater than any of
        ///  the elements in array, a negative number which is the bitwise complement of (the
        ///  index of the last element plus 1).
        /// </returns>
        public static int BinarySearch<T>(T[] arr, T item, Comparison<T> delComparison) =>
            BinarySearch(arr, 0, arr.Length, item, delComparison);
    }
}
