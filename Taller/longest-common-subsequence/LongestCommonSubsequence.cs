public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int n = text1.Length;
        int m = text2.Length;
        var prev = new int[m + 1];
        var curr = new int[m + 1];
        for (int i = 1; i <= n; i++) 
        {
            for (int j = 1; j <= m; j++) 
            {
                curr[j] = text1[i - 1] == text2[j - 1] ? 1 + prev[j - 1] : Math.Max(prev[j], curr[j - 1]);
            }
            (prev, curr) = (curr, prev);
        }
        return prev[m];
    }
}