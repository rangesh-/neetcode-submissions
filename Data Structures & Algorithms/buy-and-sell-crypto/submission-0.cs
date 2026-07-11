public class Solution {
    public int MaxProfit(int[] prices) {
        var l =0;
        var r=1;
        var profit=0;
        while(r<prices.Length){
            if(prices[l]<prices[r]){
                profit = Math.Max(profit,prices[r]-prices[l]);
            }
            else{
                l=r;
            }
            r++;
        }
        return profit;
    }
}
