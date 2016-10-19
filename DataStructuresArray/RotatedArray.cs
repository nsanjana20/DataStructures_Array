using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresArray
{
    public class RotatedArray
    {
        #region Methods
        /// <summary>
        /// 1. check if the element equals the mid value or first value or last value in the array.
        ///     then : return the value
        /// 2. else : Check if the left half is sorted or right half is sorted. 
        /// 3. If left is sorted then check if the value lies between first and mid value 
        ///     then: search for the element only in the left half by changing the length to mid value
        ///     else: search for the element in right half by moving the initial pointer i.e i = mid+1
        /// 4. If the right is sorted then check if the value lies between mid value and last value
        ///     then: search for the element in right half by moving the initial pointer i.e i = mid+1
        ///     else: search for the element only in the left half by changing the length to mid value
        /// 5. Compute the mid value again
        /// 6. Repeat steps 1 to 5 until i is less than the length of the array 
        /// </summary>
        public int FindRotatedArray(int[] arr, int x)
        {
            int len = arr.Length, i = 0, mid = len / 2, ret = -1;
            while (i < len)
            {
                if (x == arr[mid])
                {
                    ret = mid;
                    break;
                }
                if (arr[mid] < arr[i])
                { //Checking whether the right half of the array is sorted in increasing order 
                    if (x > arr[mid] && x < arr[len - 1]) //right half
                        i = mid + 1;
                    else if (x == arr[len - 1])
                    {
                        ret = len - 1;
                        break;
                    }
                    else //left half
                        len = mid;
                }
                else
                { //checking whether the left half of the array is sorted in increasing order
                    if (x > arr[i] && x < arr[mid])  //left half 
                        len = mid;
                    else // right half
                        i = mid + 1;
                }
                mid = (i + len) / 2;
            }
            return ret;
        }
        #endregion
    }
}
