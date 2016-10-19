using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresArray
{
    public class SearchElement
    {
        #region Methods
        /// <summary>
        /// 1. Check if the element equals the search term 
        /// 2. then: check whether the difference between the element before it and after it is 1 
        ///         then: return the value
        ///         else: continue
        /// 3. Repeat the steps 1 and 2 until the pointer reaches the length of the array     
        /// </summary>
        public int Search(int[] arr, int search)
        {
            int ret = -1;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] == search)
                {
                    if (Math.Abs(search - arr[i + 1]) == 1 && Math.Abs(search - arr[i - 1]) == 1)
                    {
                        ret = i;
                        break;
                    }
                }
            }
            return ret;
        }
        #endregion
    }
}
