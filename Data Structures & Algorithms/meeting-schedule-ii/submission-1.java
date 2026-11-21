/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

class Solution {
    public int minMeetingRooms(List<Interval> intervals) {
       int[] start = new int[intervals.size()];
       int[] end = new int[intervals.size()];
       int i=0;
       for(Interval interv : intervals){
         start[i]=interv.start;
         end[i]=interv.end;
         i++;
       }
       Arrays.sort(start);
       Arrays.sort(end);
       int startpointer = 0;
       int endpointer =0;
       int meetingroom =0;
       int result=0;
       while(startpointer<intervals.size()){
        if(start[startpointer]<end[endpointer]){
            meetingroom++;
            startpointer++;
        }
        else{
            endpointer++;
            meetingroom--;            
        }
        result=Math.max(result,meetingroom);
       }
         return result; 
    }
  
}
