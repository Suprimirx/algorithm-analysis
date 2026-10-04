public class Solution {
    public int NumIslands(char[][] grid) {
        int m = grid.Length, n = grid[0].Length, count = 0;
        int[] dr = { 1, -1, 0, 0 };
        int[] dc = { 0, 0, 1, -1 };

        for (int r = 0; r < m; r++) 
        {
            for (int c = 0; c < n; c++) 
            {
                if (grid[r][c] != '1') continue;

                count++;                 // isla nueva
                grid[r][c] = '0';        // hundir al encolar
                var q = new Queue<(int, int)>();
                q.Enqueue((r, c));

                while (q.Count > 0) 
                {
                    var (x, y) = q.Dequeue();
                    for (int d = 0; d < 4; d++) 
                    {
                        int nx = x + dr[d], ny = y + dc[d];
                        if (nx >= 0 && nx < m && ny >= 0 && ny < n && grid[nx][ny] == '1') 
                        {
                            grid[nx][ny] = '0';   // marcar antes de encolar
                            q.Enqueue((nx, ny));
                        }
                    }
                }
            }
        }
        return count;
    }
}