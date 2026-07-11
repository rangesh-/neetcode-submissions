public class Solution {
    public int Rob(int[] nums) {
        var results =nums; 
        
        if(nums.Length ==1){
            return nums[0];
        }

        if(nums.Length ==2){
            return Math.Max(nums[0],nums[1]);
        }
        results[1]=Math.Max(nums[0],nums[1]);
        for(var i=2;i<nums.Length;i++){
            results[i]=Math.Max(nums[i]+results[i-2], results[i-1]);
        }

        return Math.Max(results[results.Length-1],results[results.Length-2]);
    }
}
