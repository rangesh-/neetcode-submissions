public class Solution {
    public string MinWindow(string s, string t) {
        if(t.Length>s.Length){
            return "";
        }
        var res="";
        var resvalue=Int32.MaxValue;
        var tmap = GetMaps(t);
        for (int i = 0; i < s.Length; i++)
        {
            for (int len = t.Length; i + len <= s.Length; len++)
            {
                string sub = s.Substring(i, len);
                var subsetmap = GetMaps(sub);
                if(AreMapsEqual(subsetmap,tmap)){
                    if(sub.Length<resvalue){
                        res=sub;
                        resvalue=sub.Length;
                    }
                 }
            }
        }
        
        return res;
    }

    public Dictionary<char,int> GetMaps(string s){
        var dict = new Dictionary<char,int>();
        for(int i=0;i<s.Length;i++){
            
            if(dict.ContainsKey(s[i])){
                dict[s[i]]+=1;
            }
            else{
                dict[s[i]]=1;
            }
        }
        return dict;
    }

    public bool AreMapsEqual(Dictionary<char,int>subset, Dictionary<char,int> t){
        foreach(var item in t){
            if(!subset.ContainsKey(item.Key) || subset[item.Key]<item.Value){
                return false;
            }
        }

        return true;
    }
}
