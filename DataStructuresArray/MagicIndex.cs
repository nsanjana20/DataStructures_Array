using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresArray
{
    public class MagicIndex
    {
        #region Methods
        /// <summary>
        /// If the magic index exists then it must be between the value less than its index and the value greater than its index as it is a sorted array;
        /// 1. Check if mid value is greater than its index
        ///     then: we check only left half of the array by moving the length pointer to mid i.e len = mid
        /// 2. else if mid value is less than its index
        ///     then : we check only right half of the array by moving the initial pointer (i) to next value after mid i.e i = mid + 1
        /// 3. else when the mid value and its index are equal then we return the index 
        /// 4. we now calculate the new middle index again mid = (i + len)/2
        /// 5. we repeat steps 1 to 4 until i is less than array length
        /// </summary>
        public int CheckMagicIndex(int[] arr)
        {
            int i = 0, len = arr.Length, mIndex = -1;
            int mid = (i + len) / 2;
            while (i < len)
            {
                if (arr[mid] > mid)
                    len = mid;
                else if (arr[mid] < mid)
                    i = mid + 1;
                else if (mid == arr[mid])
                {
                    mIndex = mid;
                    break;
                }
                mid = (i + len) / 2;
            }
            return mIndex;
        }
        /// <summary>
        /// When values are not distinct we check each value with its index
        /// </summary>
        public int CheckNotDistinct(int[] arr)
        {
            int mIndex = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == i)
                {
                    mIndex = i;
                    break;
                }
            }
            return mIndex;
        }
        #endregion
    }
}
