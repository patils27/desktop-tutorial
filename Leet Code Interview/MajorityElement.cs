using System;

namespace InterviewQuestions
{
    public class MajorityElement
    {
        public static void Main(string[] args)
        {
            int[] nums = { 3, 2, 3 };
            Console.WriteLine(FindMajorityElement(nums));
        }

        public static int FindMajorityElement(int[] nums)
        {
            int candidate = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    candidate = nums[i];
                }

                if (candidate == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            return candidate;
        }
    }
}