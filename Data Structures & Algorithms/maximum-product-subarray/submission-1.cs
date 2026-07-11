public class Solution {
    public int MaxProduct(int[] nums) {
        var res= Int32.MinValue;
       for(var i=0;i<nums.Length;i++){
          var temp=nums[i];
           res=Math.Max(res,temp);
        for(var j=i+1;j<nums.Length;j++){

           var temp2=temp*nums[j];
            res=Math.Max(res,temp2);
            temp=temp2;
        }
        
       }
        return res;
    }
}
