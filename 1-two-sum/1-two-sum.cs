public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        if(nums == null)
            return null;
        
        var len = nums.Length;
        
        for(int i = 0; i < len; i++)
        { 
            for(int j = i + 1; j < len; j++)
            {
                var sum = nums[i] + nums[j];
                
                if(sum == target)
                {
                    return new int[] {i, j};
                }
            }
        }
        
        return null;
    }
}