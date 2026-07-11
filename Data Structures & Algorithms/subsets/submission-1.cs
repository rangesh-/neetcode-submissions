public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        
        var result = new List<List<int>>();
        result.Add(new List<int>());
        
        foreach(var num in nums) {
            int size = result.Count;
            Console.WriteLine($"--- Processing Number: {num} ---");
             Console.WriteLine($"--- Length of Subset: {size} ---");

            for(var i = 0; i < size; i++) {

                var subset = new List<int>(result[i]);
              Console.WriteLine($" subset existed: [{string.Join(", ", subset)}]");

                subset.Add(num);
                
                // Printing the subset inside the loop
                
                result.Add(subset);
            }
        }

        return result;
    }
}