class Solution {
    public int canCompleteCircuit(int[] gas, int[] cost) {
        
        int gassum=0;
        int costsum=0;
        for(int i =0;i<gas.length;i++){
         gassum+=gas[i];
         costsum+=cost[i];
        }
        if(gassum<costsum){
            return -1;
        }

        int currgas=0;
        int index=0;
        for(int i=0;i<gas.length;i++){
          
          currgas+=(gas[i]-cost[i]);
          if(currgas<0){
            currgas=0;
            index=i+1;
          }
 
        }
        return index;
    }
}
