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

     Array.Sort(hand);
foreach(var item in hand){
    if(sorteddict[item]>0){
    for(var i=item;i<item+groupSize;i++){
        if(!sorteddict.ContainsKey(i) ||sorteddict[i]==0){
            return false;
        }
        sorteddict[i]-=1;
    }
    }
}
      
     
return true;
    }
}
