using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresArray
{
    class DuplicateElement
    {
        #region Methods
        public int FindDuplicate(int[] arr)
        {
            int x = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                x += arr[i] - i;
            }
            return x;
        }
        #endregion
    }
}
