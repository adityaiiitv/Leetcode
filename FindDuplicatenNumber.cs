using System;
using System.Collections.Generic;
public class Solution {
    public int FindDuplicate(int[] nums) {
        Array.Sort(nums);
        int l = nums.Length;
        for(int i=1;i<l;i++)
        {
            if(nums[i]==nums[i-1])
            {
                return nums[i];
            }
        }
        return 0;
    }
}