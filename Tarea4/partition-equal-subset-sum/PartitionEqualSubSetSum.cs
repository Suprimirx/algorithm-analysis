public class Solution
{
    public bool CanPartition(int[] nums)
    {
        int total = nums.Sum();
        if (total % 2 != 0) return false;
 
        int W = total / 2;
        bool[] dp = new bool[W + 1];       // dp[w] = ¿algún subconjunto de los ítems vistos suma w?
        dp[0] = true;                      // caso base: la suma vacía
 
        foreach (int num in nums)
        {
            // hacia ATRÁS: así dp[w - num] todavía no incluye a `num` (uso a lo más una vez)
            for (int w = W; w >= num; w--)
                dp[w] = dp[w] || dp[w - num];
 
            if (dp[W]) return true;
        }
 
        return dp[W];
    }
}