public class Solution
{
    public int CoinChange(int[] coins, int amount)
    {
        int INF = amount + 1;              
        int[] dp = new int[amount + 1]; 
        Array.Fill(dp, INF);
        dp[0] = 0;

        for (int x = 1; x <= amount; x++)          // hacia ADELANTE: las monedas se reusan
        {
            foreach (int c in coins)
            {
                if (c <= x)
                    dp[x] = Math.Min(dp[x], 1 + dp[x - c]);
            }
        }

        return dp[amount] >= INF ? -1 : dp[amount];
    }
}