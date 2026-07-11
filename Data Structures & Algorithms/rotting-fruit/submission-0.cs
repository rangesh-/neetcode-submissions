public class Solution {
    public int OrangesRotting(int[][] grid) {
        var queue = new Queue<int[]>();
        var fresh=0;
        var directions = new int[][]
        {
            new int[]{0,1},
            new int[]{0,-1},
            new int[]{1,0},
            new int[]{-1,0}            
        };
        
        for(var i =0 ; i<grid.Length;i++){
            for(var j=0;j<grid[0].Length;j++){
               if(grid[i][j]==1){
                fresh++;
               }
                if(grid[i][j]==2){
                    queue.Enqueue(new int[]{i,j});
                }
            }
        }

        int time = 0;
        while( fresh>0 && queue.Count>0){
            var length = queue.Count;
          for( int t =0 ; t<length;t++){  
            var element = queue.Dequeue();
            var r = element[0];
            var c= element[1];
          
                
                foreach (var dir in directions){
                 var nr = r+dir[0];
                 var nc = c+dir[1]; 
                 if(nr>=0 && nc>=0 && nr<grid.Length && nc<grid[0].Length && grid[nr][nc]==1){
                  queue.Enqueue(new int[]{nr,nc});
                  grid[nr][nc]=2;
                  fresh -- ;
                 }

                }
          }
          time++;
                
            }
        
        return fresh == 0 ? time : -1;
}
        }
        

    

