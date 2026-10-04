public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        int n = intervals.Length;
        MergeSort(intervals, new int[n][], 0, n - 1);

        var res = new List<int[]>();
        int[] cur = new int[] { intervals[0][0], intervals[0][1] };
        for (int i = 1; i < n; i++)
        {
            if (intervals[i][0] <= cur[1])
            {
                cur[1] = Math.Max(cur[1], intervals[i][1]);
            }
            else
            {
                res.Add(cur);
                cur = new int[] { intervals[i][0], intervals[i][1] };
            }
        }
        res.Add(cur);
        return res.ToArray();
    }

    void MergeSort(int[][] a, int[][] tmp, int lo, int hi)
    {
        if (lo >= hi) return;
        int mid = lo + (hi - lo) / 2;
        MergeSort(a, tmp, lo, mid);
        MergeSort(a, tmp, mid + 1, hi);

        int i = lo, j = mid + 1, k = lo;
        while (i <= mid && j <= hi)
        {
            tmp[k++] = a[i][0] <= a[j][0] ? a[i++] : a[j++];
        }
        while (i <= mid)
        {
            tmp[k++] = a[i++];
        }
        while (j <= hi)  
        {
            tmp[k++] = a[j++];
        }
        for (k = lo; k <= hi; k++) 
        {
            a[k] = tmp[k];
        }
    }
}