public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        int[] parent = new int[edges.Length + 1];
        int[] rank = new int[edges.Length+1];
    for (int i = 0; i < parent.Length; i++) 
    {
        parent[i] = i;
        rank[i]=1;
    }
     
     foreach(var edge in edges){
        if(!union(parent,rank,edge[0],edge[1])){
            return new int[]{edge[0],edge[1]};
        }

    
     }

         return new int[0];

    }

    public int Find(int[]parent ,int edge){
        var i =parent[edge];
        while(i!=parent[i]){
           i=parent[i];
        }
        return i; 
     }

     public bool union(int[] parent, int[] rank , int u,int v){
        int p1 = Find(parent,u);
        int p2= Find(parent,v);
        if(p1==p2){
            return false;
        }

        if(rank[p1]>rank[p2]){
            parent[p2]=p1;
            rank[p1]+=rank[p2];
        }else{
             parent[p1]=p2;
            rank[p2]+=rank[p1];
        }
        return true;

     }
}
