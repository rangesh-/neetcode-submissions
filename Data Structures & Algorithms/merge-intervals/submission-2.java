class Solution {
    public int[][] merge(int[][] intervals) {
        Arrays.sort(intervals,(a,b)->Integer.compare(a[0],b[0]));
       List<int[]> result = new ArrayList<>();
       result.add(intervals[0]);

       for(int[] interval : intervals )
       {
        int start = interval[0];
        int end = interval[1];
        int lastend = result.get(result.size()-1)[1];
        if(start<=lastend){
           result.get(result.size()-1)[1] = Math.max(lastend,end);
        }
        //new index
        else {
         result.add(new int[]{start,end});
        }
       }
        return result.toArray(new int[result.size()][]);
    }
}
