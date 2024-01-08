using System;

public class DuplicateChecker
{
    public bool ContainsDuplicate(int[] nums)
    {
        Array.Sort(nums);
        int length = nums.Length;
        for (int i = 1; i < length; i++)
        {
            if (nums[i] == nums[i - 1])
                return true;
        }
        return false;
    }
}