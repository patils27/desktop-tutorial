using System;
using System.Collections.Generic;

namespace InterviewQuestions
{
    public class TwoSum
    {
        public static void Main(string[] args)
        {
            int[] nums = { 3, 3 };
            Console.WriteLine(string.Join(", ", TwoSum(nums, 6)));
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> hm = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int reqNum = target - nums[i];
                if (hm.ContainsKey(reqNum))
                {
                    int[] arr = { hm[reqNum], i };
                    return arr;
                }
                hm[nums[i]] = i;
            }
            return null;
        }
    }
}