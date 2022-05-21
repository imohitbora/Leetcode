public class Solution {
    
    public int CoinChange(int[] coins, int t) 
    {
        if(coins == null) return -1;
        
        var dp = new int[t + 1];
        
        for(int i = 0; i < t + 1; i++)
        {
            dp[i] = 10001;
        }
        
        dp[0] = 0;
        
        for(int j = 0; j < coins.Length; j++)
        {
            for(int i = coins[j]; i < t + 1; i++)
            {
                dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
            }
        }
        
        return dp[t] == 10001 ? -1 : dp[t];
    }
}