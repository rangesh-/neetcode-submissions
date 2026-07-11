public class Solution {
    public int ClimbStairs(int n) {     
        var firststep=1;
        var secondstep=1;

        for(var i=0;i<n-1;i++){
         var temp=firststep;   
         firststep = firststep+secondstep;
         secondstep=temp;
        }

        return firststep;
    }
}
