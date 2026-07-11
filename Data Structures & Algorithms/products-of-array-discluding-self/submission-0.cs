public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result = new int[nums.Length];
        Array.Fill(result,1);      
        for(var i=0;i<=nums.Length-1;i++){
            Console.WriteLine(nums[i]);
            for(var j=0;j<=nums.Length-1;j++){
                if(i!=j){
                 result[i]=result[i]*nums[j];
                }
            }
        }
        return result;
    }
}
