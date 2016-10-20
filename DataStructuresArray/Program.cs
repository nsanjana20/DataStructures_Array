using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresArray
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MagicIndex
            int[] mIarr = { -1, 1, 3, 4, 8 };
            MagicIndex mI = new MagicIndex();
            Console.WriteLine(mI.CheckMagicIndex(mIarr));
            #endregion

            #region Rotated Array
            RotatedArray rt = new RotatedArray();
            int[] rtArr = { 32, 40, 1, 2, 5, 7, 10, 17, 25 };
            int num = 2;
            int rtIndex = rt.FindRotatedArray(rtArr, num);
            Console.WriteLine("(Binary search) The value is at the index : " + rtIndex);
            #endregion

            #region SearchElement
            int[] adjArr = { 8, 7, 6, 7, 6, 5, 4, 3, 2, 3, 4, 3 };
            int search = 3;
            SearchElement se = new SearchElement();
            int element = se.Search(adjArr, search);
            Console.WriteLine("The search element " + search + " is found at index: " + element);
            #endregion

            #region Duplicate Element
            int[] dupArr = { 2, 4, 3, 2, 1 };
            DuplicateElement d = new DuplicateElement();
            Console.WriteLine("The duplicate element is: "+d.FindDuplicate(dupArr));
            #endregion

            #region Split array
            int[] splitArr = { 2, 6, 10, 4, 29, 7 };
            SplitArray s = new SplitArray();
            Console.WriteLine("The sum of the n-1 numbers is found at index: "+s.Split(splitArr));
            #endregion
        }
    }
}
