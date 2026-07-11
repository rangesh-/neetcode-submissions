public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        // 1. Initialization fix
        var res = new List<List<int>>();
        var path = new List<int>();
        
        // 2. MUST SORT to handle duplicates effectively
        Array.Sort(candidates);
        
        backtrack(0, res, path, candidates, target);
        return res;
    }

    public void backtrack(int index, List<List<int>> result, List<int> path, int[] input, int target) {
        if (target == 0) {
            result.Add(new List<int>(path));
            return;
        }
        if (target < 0) {
            return;
        }

        for (int i = index; i < input.Length; i++) {
            // 3. SKIP DUPLICATES at the same level of recursion
            // If i > index, it means we already tried this value in a previous loop iteration
            if (i > index && input[i] == input[i - 1]) continue;

            path.Add(input[i]);
            
            // 4. Use i + 1 so we move to the next physical element
            backtrack(i + 1, result, path, input, target - input[i]);
            
            path.RemoveAt(path.Count - 1);
        }
    }
}