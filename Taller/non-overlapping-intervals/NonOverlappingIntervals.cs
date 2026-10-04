public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        int n = intervals.Length;
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));   // por end ascendente

        int kept = 1;    // el primero siempre cabe                    
        int lastEnd = intervals[0][1];

        for (int i = 1; i < n; i++) 
        {
            if (intervals[i][0] >= lastEnd) // no pisa al último aceptado
            {   
                kept++;
                lastEnd = intervals[i][1];
            }
            // si pisa, se descarta (se "borra") y lastEnd no cambia
        }
        return n - kept;
    }
}