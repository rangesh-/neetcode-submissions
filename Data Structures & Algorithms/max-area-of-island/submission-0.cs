public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        var maxarea=0;
        for (int i=0;i<grid.Length;i++){
            for(int j=0;j<grid[i].Length;j++){
               if(grid[i][j]==1){        
                maxarea=Math.Max(maxarea,dfs(grid,i,j));
                }
            }
        }
        return maxarea;
        }

        public int dfs(int[][]grid, int i,int j){
            if(i<0 || j<0 || i>=grid.Length || j>=grid[i].Length || grid[i][j]==0){
                return 0;
            }
          
            int res=1;
              grid[i][j]=0;
            res+=dfs(grid,i+1,j);
            res+=dfs(grid,i-1,j);
            res+=dfs(grid,i,j+1);            
            res+=dfs(grid,i,j-1);
            return res;
        }
    }

