public class Solution {
    public int MaxArea(int[] heights) {
        
        var left =0;
        var right =heights.Length-1;
        int maxarea=0;
        while(left<right){
          
          var minheight = Math.Min(heights[left],heights[right]);
          var capacity = right-left;
          maxarea=Math.Max(maxarea,(minheight*capacity));
          
          if(heights[left]>=heights[right]){
           right --;
          }

          else {
            left++;
          }

            
        }

        return maxarea;
    }
}
