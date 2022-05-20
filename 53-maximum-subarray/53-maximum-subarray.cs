using System;

public class Solution {
    public int MaxSubArray(int[] nums) {
        
        if(nums == null)
        {
            return 0;
        }
        
        int cur_sum = -10001, max_sum = -10001;
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(cur_sum + nums[i] > nums[i])
            {
                cur_sum += nums[i];
            }
            else if(nums[i] > cur_sum)
            {
                cur_sum = nums[i];
            }
            else
            {
                cur_sum = -10001;
            }
            
            max_sum = Math.Max(cur_sum, max_sum);
        }
        
        return max_sum;
    }
}