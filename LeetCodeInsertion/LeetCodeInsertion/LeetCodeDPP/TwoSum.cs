using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInsertion.LeetCodeDPP
{
    public class TwoSum
    {
        public int[] TwoSumArray(int[] nums, int target) {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int compli = target - nums[i];
                for(int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == compli && j>i)
                    {
                        result.Add(i);
                        result.Add(j);
                    }
                }
            }
            return result.ToArray();

        }
    }
}
