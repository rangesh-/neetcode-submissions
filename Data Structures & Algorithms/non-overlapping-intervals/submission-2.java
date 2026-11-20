class Solution {
    public int eraseOverlapIntervals(int[][] intervals) {
        Arrays.sort(intervals,(a,b)->Integer.compare(a[0],b[0]));
        int prevend = intervals[0][1];
         int res=0; 
        for(int i=1;i<intervals.length;i++){
            var start = intervals[i][0];
            var end = intervals[i][1];
            if(prevend>start){
                prevend = Math.min(prevend, end);
            res++;
            }
            else{
                prevend= end;
            }
        }
        return res;


    }
}
