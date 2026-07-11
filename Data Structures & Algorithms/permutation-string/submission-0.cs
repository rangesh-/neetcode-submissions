public class Solution {
    public bool CheckInclusion(string s1, string s2) {
       if (s1.Length > s2.Length) return false;

       
        var s1map = Getmaps(s1);

        for(int i=0;i<=s2.Length-s1.Length;i++){
            string sub = s2.Substring(i, s1.Length);
           // Console.WriteLine(sub);
            var submap = Getmaps(sub);
            if(AreMapsEqual(s1map,submap)){
                return true;
            }
        }

     return false;
    }

    public Dictionary<char,int> Getmaps(string s1){
          var s1dict = new Dictionary<char, int>();
        for(int i=0;i<s1.Length;i++){
            if(s1dict.ContainsKey(s1[i])){
                s1dict[s1[i]]+=1;
            }
            else{
                s1dict[s1[i]]=1;
            }
        }
       return s1dict;
    }

    public bool AreMapsEqual(Dictionary<char,int>s1, Dictionary<char,int>s2 ){
       if(s1.Count!=s2.Count){
        return false;
       } 

       foreach(var item in s1){
        if(!s2.ContainsKey(item.Key)||s2[item.Key] !=item.Value){
            return false;
        }
      
       }
       return true;
    }
}
