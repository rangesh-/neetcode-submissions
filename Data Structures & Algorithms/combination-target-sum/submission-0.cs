public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var res = new List<List<int>>();
        var currentpath = new List<int>();
        backtrack(0, currentpath, res, nums, target);
        return res;
    }

    public void backtrack(int currentelement, List<int> currentpath, List<List<int>> res, int[] input, int target) {
        // SUCCESS:
        if (target == 0) {
            res.Add(new List<int>(currentpath)); // Correct deep copy syntax
            return;
        }
        
        // FAILURE:
        if (target < 0) {
            return;
        }

        // Fix: start 'i' at 'currentelement' to avoid duplicate [3,2]
        for (int i = currentelement; i < input.Length; i++) {
            currentpath.Add(input[i]); // Choose
            
            // Recurse with 'i' to allow reuse
            backtrack(i, currentpath, res, input, target - input[i]);
            
            currentpath.RemoveAt(currentpath.Count - 1); // Backtrack (Undo)
        }
    }
}