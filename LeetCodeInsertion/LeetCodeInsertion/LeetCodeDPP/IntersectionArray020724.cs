using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInsertion.LeetCodeDPP
{
    public class IntersectionArray020724
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            int index = 0;
            List<int> result = new List<int>();
            int i = 0;
            int j = 0;

            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    i++;
                }
                else if (nums1[i] > nums2[j])
                {
                    j++;
                }
                else
                {
                    result.Add(nums1[i]);
                    i++;
                    j++;
                }
            }

            return result.ToArray();
        }

    }
}
