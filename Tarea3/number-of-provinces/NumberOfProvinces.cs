public class Solution
{
    public int FindCircleNum(int[][] isConnected)
    {
        int n = isConnected.Length;
        bool[] visited = new bool[n];
        int provinces = 0;

        for (int i = 0; i < n; i++)
        {
            if (!visited[i])
            {
                provinces++;
                Dfs(i, visited, isConnected, n);
            }
        }
        return provinces;

    }

    private void Dfs(int city, bool[] visited, int[][] isConnected, int n)
    {
        visited[city] = true;
        for (int j = 0; j < n; j++)
        {
            if (isConnected[city][j] == 1 && !visited[j])
            {
                Dfs(j, visited, isConnected, n);
            }
        }
    }
}