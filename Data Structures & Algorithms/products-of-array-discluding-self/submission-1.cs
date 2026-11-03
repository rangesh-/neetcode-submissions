public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
       var left = new int[nums.Length];
       var right = new int [nums.Length];

       left[0]=1;
       for(int i =1;i<nums.Length;i++){
        left[i]=left[i-1]*nums[i-1];
       }
       right[nums.Length-1]=1;
       for(int j=nums.Length-2;j>-1;j--){
        right[j] = right[j+1]*nums[j+1];
       }

       var ans = new int[nums.Length];
       for(int i=0;i<nums.Length;i++){
        ans[i]= left[i]*right[i];
       }

       return ans;
    }
}
