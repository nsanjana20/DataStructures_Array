using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresArray
{
    class SplitArray
    {
        #region Methods
        /// <summary>
        /// We need to find whether the array contains the sum of the other numbers and to return the index if the sum exists
        /// 1. Find the sum of all the numbers in the array and divide it by 2 to get the sum of the n-1 numbers.
        /// 2. if the element equals the sum of n-1 numbers then: return the index of the sum
        /// 3. Repeat step 2 for all the values in the array or till the value is found
        /// </summary>
        public int Split(int[] arr)
        {
            int index = -1, totalSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                totalSum += arr[i];
            }
            int sum = totalSum / 2;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == sum)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        #endregion
    }
}
