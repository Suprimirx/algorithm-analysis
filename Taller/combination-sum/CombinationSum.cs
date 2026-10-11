public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        Array.Sort(candidates);                       // permite podar con break
        var res = new List<IList<int>>();
        Backtrack(candidates, target, 0, new List<int>(), res);
        return res;
    }

    private void Backtrack(int[] c, int remaining, int start, List<int> path, IList<IList<int>> res) 
    {
        if (remaining == 0) 
        {
            res.Add(new List<int>(path));             // copia, no la referencia
            return;
        }
        for (int i = start; i < c.Length; i++) 
        {
            if (c[i] > remaining) break;              // poda: los siguientes son mayores

            path.Add(c[i]);                           // ELEGIR
            Backtrack(c, remaining - c[i], i, path, res);   // EXPLORAR i: reutilizable
            path.RemoveAt(path.Count - 1);            // DESHACER
        }
    }
}