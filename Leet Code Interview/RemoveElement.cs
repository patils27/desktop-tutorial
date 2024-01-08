using System;

namespace InterviewQuestionsCSharp
{
    class RemoveElement
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;
            Console.WriteLine(RemoveElement(nums, val));
        }

        static int RemoveElement(int[] nums, int val)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[count] = nums[i];
                    count++;
                }
            }
            Console.WriteLine(nums[count]);
            return count;
        }
    }
}