using LeetCodeInsertion.LeetCodeDPP;

public class Program
{
    public static void Main()
    {

        #region Intersection Program
        //IntersectionArray020724 solution = new IntersectionArray020724();
        //int[] nums1 = { 1, 2, 2, 1 };  // nums1 = [4,9,5]  
        //int[] nums2 = { 2, 2 };  // nums2 = [9, 4, 9, 8, 4]
        //int[] intersection = solution.Intersect(nums1, nums2);

        //// Output the result
        //Console.WriteLine(string.Join(", ", intersection)); // Output: 2, 2

        #endregion



        #region Two Sum program
        TwoSum solution = new TwoSum();
        int[] nums = { 3,2,3 };  // {3,2,4}  // {3,3}
        int target = 6;  //6 //6
        int[] twoSum = solution.TwoSumArray(nums, target);

        // Output the result
        Console.WriteLine(string.Join(", ", twoSum)); // Output: 2, 2
        #endregion
    }


}
