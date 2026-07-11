public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        var dict = new Dictionary<int,List<int>>();
        var visited = new int[numCourses];
        var result = new List<int>();
        for( int i =0 ;i<numCourses;i++){
            dict[i] = new List<int>();
        }

        foreach(var pre in prerequisites){
            dict[pre[0]].Add(pre[1]);
        }

        for( int i =0 ; i<numCourses;i++){   
            if(!hascycles(i,dict,visited, result)){
             return new int[0];
            }
        }
        return result.ToArray();
    }

    public bool hascycles(int courses,Dictionary<int,List<int>> dict, int[] visited, List<int> result)
    {
            if(visited[courses]==1){
                return false;
            }
            if(visited[courses]==2){
                return true;
            }

            visited[courses]=1;
            
            var newcourses = dict[courses];

            foreach(var course in newcourses){
                if(!hascycles(course,dict,visited, result)){
                   return false;
                }
            }

            visited[courses]=2;
            result.Add(courses);
            return true;
    }
}