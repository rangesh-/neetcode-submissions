public class Solution {
   private int[][] directions = new int[][]{
        new int[]{0,1},
        new int[]{0,-1},
        new int[]{1,0},
        new int[]{-1,0}
      };  
    public List<List<int>> PacificAtlantic(int[][] heights) {
    

      var rows = heights.Length;
      var cols = heights[0].Length;
      var pacificq = new Queue<int[]>();
      var altq = new Queue<int[]>();

      var pac = new bool[rows, cols];
      var alt = new bool[rows,cols];
    
  for (int c = 0; c < cols; c++) {
            pacificq.Enqueue(new int[] { 0, c });
            altq.Enqueue(new int[] { rows - 1, c });
        }
        for (int r = 0; r < rows; r++) {
            pacificq.Enqueue(new int[] { r, 0 });
            altq.Enqueue(new int[] { r, cols - 1 });
        }
  List<List<int>> res = new List<List<int>>();
        Bfs(pacificq, pac, heights);
        Bfs(altq, alt, heights);
        for(int r=0;r<rows;r++){
          for(int c=0;c<cols;c++){
            if(pac[r,c] && alt[r,c]){
               res.Add(new List<int> { r, c });
            }
          }
        }
       return res;    
    }
      public void Bfs(Queue<int[]> q,bool[,] ocean ,int[][] heights){
        while(q.Count>0){
          var current = q.Dequeue();
           var r = current[0];
           var c = current[1];
           ocean[r,c]=true;
           foreach (var dir in directions){
            var nr = dir[0]+r;
            var nc = dir[1]+c;

            if(nr>=0 && nr<heights.Length && nc >=0 && nc<heights[0].Length && !ocean[nr,nc] && heights[nr][nc]>=heights[r][c]) {
             q.Enqueue(new int[] { nr, nc });
            }
           }
        } 
      }

    }

