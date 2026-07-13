public class Solution {
    public int[][] Merge(int[][] intervals) {
     Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
     var output = new List<int[]>();
     output.Add(intervals[0]);
     foreach( var interval in intervals){
        var start = interval[0];
        var end= interval[1];
        var prev = output[output.Count-1];
        var prevendinterval = prev[1];
        
        if(start<=prevendinterval){
        output[output.Count-1][1]=Math.Max(prevendinterval,end);
        }
        else{
            output.Add(new int[] {start,end});
        }
     }
     return output.ToArray();
    }
}
