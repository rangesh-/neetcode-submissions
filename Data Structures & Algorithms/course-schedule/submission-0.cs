public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
       
        var adj = new Dictionary<int, List<int>>();
        for (int i = 0; i < numCourses; i++) {
            adj[i] = new List<int>();
        }
        
        foreach (var pre in prerequisites) {
            adj[pre[0]].Add(pre[1]); // Course 'a' depends on 'b'
        }

        int[] visitedstate = new int[numCourses];

        for(int i=0;i<numCourses;i++){
            if (!HasCycle(i, adj, visitedstate)){
             return false;
            }
        }
        return true;
        }

        public bool HasCycle(int course, Dictionary<int, List<int>> adj, int[] visitState){

            if(visitState[course]==1){
                return false;
            }
           if(visitState[course]==2){
                return true;
            }
             

            visitState[course]=1;
            var courses = adj[course];
            foreach( var nextcourse in courses){
                if(!HasCycle(nextcourse ,adj,visitState)){
                    return false;
                }
            }
             visitState[course]=2;
            return true;
        }
    }

