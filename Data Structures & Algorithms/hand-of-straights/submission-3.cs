public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
     
if (hand.Length % groupSize != 0) return false;
     var sorteddict = new  SortedDictionary<int, int>();
      foreach(var item in hand){
        if(sorteddict.ContainsKey(item)){
            sorteddict[item]+=1;
        }
        else{
            sorteddict[item]=1;
        }
      }
      foreach(var card in new List<int>(sorteddict.Keys)){
        var count = sorteddict[card];;
        if(count>0){
        for(int i=0;i<groupSize;i++){
            var nextcard = card+i;
            if(!sorteddict.ContainsKey(nextcard) || sorteddict[nextcard]<=0 ){
                return false;
            }
            sorteddict[nextcard]-=count;
        }
        }
      }

return true;
    }
}
