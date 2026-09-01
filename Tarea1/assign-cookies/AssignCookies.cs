public class Solution
{
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);

        int contentChild = 0;
        int cookies = 0;
        
        while (contentChild < g.Length && cookies < s.Length)
        {
            if (s[cookies] >= g[contentChild])
            {
                contentChild++;
            }
            cookies++;
        }
        return contentChild;
    }
}
