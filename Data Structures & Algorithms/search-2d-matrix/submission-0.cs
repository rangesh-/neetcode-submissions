public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
         
         var rows = matrix.Length;
         var cols = matrix[0].Length;

        var top=0;
        var bot = rows-1;
        var targetrow =-1;
        while(top<=bot){
            var mid = top+((bot-top)/2);
            if (matrix[mid][0] <= target && target <= matrix[mid][cols - 1]) {
              targetrow=mid;
              break;
            }else if(matrix[mid][0]>target){
                bot=mid-1;
            }
            else{
                top = mid+1;
            }
        }

        if(targetrow==-1){
            return false;
        } 
        var nums = matrix[targetrow];
        var start=0;
        var end = nums.Length-1;
        while(start<=end){
           var mid = start+((end-start)/2);
           if(nums[mid]==target){
            return true;
           } 
           else if (nums[mid]>target){
            end=mid-1;
           }
           else{
            start=mid+1;
           }
        }
        return false;
    }
}
