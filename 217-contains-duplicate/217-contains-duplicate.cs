public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        if(nums == null)
            return false;
        
        var hash = new Dictionary<int, int>();
        
        foreach(var n in nums)
        {
            if(hash.ContainsKey(n))
            {
                return true;
            }
            else
            {
                hash.Add(n, 1);
            }
        }
        
        return false;
    }
}