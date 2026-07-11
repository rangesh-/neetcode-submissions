public class Solution {
    public int CharacterReplacement(string s, int k) {
       var res=0;
       for(int i=0;i<s.Length;i++){
        var c =s[i];
        var t=k;
        var temp=0;

        for(int j=i;j<s.Length;j++){
         if(c==s[j]){
            temp++;
         }
         else{
          if(t>0){
            t--;
            temp++;
          }
          else{
            break;
          }
         }
        }
       res = Math.Max(res, Math.Min(temp + t, s.Length));
       }

       return res;
    }
}
