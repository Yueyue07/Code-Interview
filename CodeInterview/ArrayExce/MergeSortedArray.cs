using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExce
{
    public static class Exce1
    {
        public static int[] MergeSortedArray(int[] array1, int[] array2 )
        {
            int[] nums1 = array1;
            int[] nums2 = array2;

            int index1 = nums1.Length - 1, index2 = nums2.Length - 1;
            var index = index1 + index2 + 1;
            int[] result = new int[index + 1];

            while (index >= 0)
            {
                if (index1 == index)
                {
                    result[index--] = nums1[index1--];
                }
                else if (index2 == index)
                {
                    result[index--] = nums2[index2--];
                }
                else
                {
                    if (nums1[index1] <= nums2[index2])
                    {
                        result[index--] = nums2[index2--];
                    }
                    else
                    {
                        result[index--] = nums1[index1--];
                    }
                }

            }

            return result;
        }
    }
}
