using System;

namespace InterviewQuestionsCSharp
{
    class MergeSortedArray
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };
            int n = 3;
            int m = 3;
            Console.WriteLine(string.Join(",", Merge(nums1, m, nums2, n)));
        }

        static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = m - 1;
            int p2 = n - 1;
            int p = m + n - 1;

            while (p2 >= 0 && p1 >= 0)
            {
                if (nums1[p1] >= nums2[p2])
                {
                    nums1[p--] = nums1[p1--];
                }
                else
                {
                    nums1[p--] = nums2[p2--];
                }
            }
            while (p1 >= 0)
            {
                nums1[p--] = nums1[p1--];
            }
            while (p2 >= 0)
            {
                nums1[p--] = nums2[p2--];
            }
            return nums1;
        }
    }
}