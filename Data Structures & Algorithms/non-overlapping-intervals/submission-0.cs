public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals,(a,b)=>a[0].CompareTo(b[0]));
        var prevend = intervals[0][1];
        var res=0;
        for(int i=1 ;i<intervals.Length;i++){

            var start = intervals[i][0];
            var end = intervals[i][1];
            if(start >=prevend){
             prevend=end;
            }
            else{
              res++;
              prevend=Math.Min(end,prevend);
            }
        }

        return res;
    }
}
