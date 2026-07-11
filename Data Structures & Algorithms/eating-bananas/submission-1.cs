public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        
        var speed=1;
        while(true){
            long time=0;
            foreach(var pile in piles){
                time+=(int)Math.Ceiling((double)pile/speed);
            }
            if(time<=h){
                return speed;
            }
            speed++;
        }

    }
}
